using KASIR.Model;
using KASIR.Network;
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

namespace KASIR.Komponen
{
    public partial class dataDiskon : Form
    {
        private readonly string baseOutlet;
        public bool ReloadDataInBaseForm { get; private set; }
        public dataDiskon()
        {
            baseOutlet = Properties.Settings.Default.BaseOutlet;
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            try
            {
                IApiService apiService = new ApiService();
                string response = await apiService.GetDiscount("/discount","");

                DiscountCartModel menuModel = JsonConvert.DeserializeObject<DiscountCartModel>(response);
                List<DataDiscountCart> menuList = menuModel.data.ToList();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ID", typeof(int));
                dataTable.Columns.Add("Kode", typeof(string));
                dataTable.Columns.Add("Nilai", typeof(string));
                dataTable.Columns.Add("Minimum", typeof(string));
                dataTable.Columns.Add("Durasi", typeof(string));
                foreach (DataDiscountCart menu in menuList)
                {
                    dataTable.Rows.Add(menu.id, menu.code, menu.value, menu.min_purchase, menu.start_date.ToString().Substring(0, Math.Min(menu.start_date.ToString().Length, 10))
                    +" - " +menu.end_date.ToString().Substring(0, Math.Min(menu.end_date.ToString().Length, 10)));
                }

                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal tampil data diskon  " + ex.Message,"Gaspol");
            }
        }


        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
