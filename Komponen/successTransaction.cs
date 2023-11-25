using KASIR.komponen;
using KASIR.Model;
using KASIR.Network;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace KASIR.Komponen
{
    public partial class successTransaction : UserControl
    {
        private ApiService apiService;
        private DataTable originalDataTable;
        private readonly string baseOutlet;
        private inputPin pinForm;
        public successTransaction()
        {
            baseOutlet = Properties.Settings.Default.BaseOutlet;
            InitializeComponent();
            apiService = new ApiService();
         
            LoadData();
        }
        

        private void OpenRefundForm(string transaksiId)
        {
            refund refundForm = new refund(transaksiId);
            refundForm.RefundSuccessful += OnRefundSuccess;
            if (pinForm != null && !pinForm.IsDisposed)
            {
                pinForm.Close();
            }
            refundForm.ShowDialog();
        }

        private void OnRefundSuccess(object sender, EventArgs e)
        {
            // Refresh data in successTransaction form
            LoadData();
        }
        public async void LoadData()
        {
            try
            {
                string response = await apiService.Get("/transaction?outlet_id=" + baseOutlet + "&is_success=true");

                GetMenuModel menuModel = JsonConvert.DeserializeObject<GetMenuModel>(response);
                List<Menu> menuList = menuModel.data.ToList();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ID", typeof(int));
                dataTable.Columns.Add("Receipt Number", typeof(string));
                dataTable.Columns.Add("ID Outlet", typeof(int));
                dataTable.Columns.Add("ID Cart", typeof(int));
                dataTable.Columns.Add("Customer Name", typeof(string));
                dataTable.Columns.Add("Customer Seat", typeof(string));
                foreach (Menu menu in menuList)
                {
                    dataTable.Rows.Add(menu.id, menu.receipt_number, menu.outlet_id, menu.cart_id, menu.customer_name, menu.customer_seat);
                }

                dataGridView1.DataSource = dataTable;
                originalDataTable = dataTable.Copy();
                dataGridView1.Columns["ID"].Visible = false;
                dataGridView1.Columns["ID Outlet"].Visible = false;
                dataGridView1.Columns["ID Cart"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving data: " + ex.Message);
            }
        }
        private void PerformSearch()
        {
            if (originalDataTable == null)
                return;

            string searchTerm = textBox1.Text.ToLower();

            DataTable filteredDataTable = originalDataTable.Clone();

            IEnumerable<DataRow> filteredRows = originalDataTable.AsEnumerable()
                .Where(row => row.ItemArray.Any(field => field.ToString().ToLower().Contains(searchTerm)));

            foreach (DataRow row in filteredRows)
            {
                filteredDataTable.ImportRow(row);
            }
            dataGridView1.DataSource = filteredDataTable;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                
                LoadPin(id);
                //  OpenRefundForm(id.ToString());
                /* using (refund refund = new refund(id.ToString()))
                 {
                     refund.Owner = background;

                     background.Show();

                     DialogResult dialogResult = refund.ShowDialog();

                     background.Dispose();

                     if (dialogResult == DialogResult.Yes && refund.ReloadDataInBaseForm)
                     {
                         ReloadData();
                     }
                 }*/
            }
        }

        private void LoadPin(int id)
        {
            Form background = new Form
            {
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = 0.7d,
                BackColor = Color.Black,
                WindowState = FormWindowState.Maximized,
                TopMost = true,
                Location = this.Location,
                ShowInTaskbar = false,
            };
            using (inputPin pinForm = new inputPin(id))
            {
                pinForm.Owner = background;

                background.Show();

                DialogResult dialogResult = pinForm.ShowDialog();

                background.Dispose();

               
            }
        }

        private void ReloadData()
        {
            LoadData();
        }

        private void btnReportShift_Click(object sender, EventArgs e)
        {
            Form background = new Form
            {
                StartPosition = FormStartPosition.Manual,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = 0.7d,
                BackColor = Color.Black,
                WindowState = FormWindowState.Maximized,
                TopMost = true,
                Location = this.Location,
                ShowInTaskbar = false,
            };

            using (printReportShift payForm = new printReportShift(this))
            {
                payForm.Owner = background;

                background.Show();

                DialogResult dialogResult = payForm.ShowDialog();

                background.Dispose();

                /*if (printReportShift.KeluarButtonPrintReportShiftClicked)
                {
                    LoadData(); 
                }
*/
                if (dialogResult == DialogResult.OK && payForm.ReloadDataInBaseForm)
                {
                    LoadData();

                }
            }
        }

        private void btnNotifikasiPengeluaran_Click(object sender, EventArgs e)
        {
            Form background = new Form
            {
                StartPosition = FormStartPosition.Manual,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = 0.7d,
                BackColor = Color.Black,
                WindowState = FormWindowState.Maximized,
                TopMost = true,
                Location = this.Location,
                ShowInTaskbar = false,
            };

            using (notifikasiPengeluaran notifikasiPengeluaran = new notifikasiPengeluaran(this))
            {
                notifikasiPengeluaran.Owner = background;

                background.Show();

                DialogResult dialogResult = notifikasiPengeluaran.ShowDialog();

                background.Dispose();

                /*if (printReportShift.KeluarButtonPrintReportShiftClicked)
                {
                    LoadData(); 
                }
*/
                if (dialogResult == DialogResult.OK && notifikasiPengeluaran.ReloadDataInBaseForm)
                {
                    LoadData();
                }
            }
        }
    }
}
