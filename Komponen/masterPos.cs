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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Menu = KASIR.Model.Menu;

namespace KASIR.komponen
{
    public partial class masterPos : Form
    {
        private ApiService apiService;
        private DataTable originalDataTable;
        public masterPos()
        {
            InitializeComponent();
            apiService = new ApiService();

            // Retrieve data from the API and bind it to the DataGridView
            LoadData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void PerformSearch()
        {
            if (originalDataTable == null)
                return;

            string searchTerm = txtCari.Text.ToLower();

            // Create a new DataTable to store the filtered rows
            DataTable filteredDataTable = originalDataTable.Clone();

            // Filter the rows based on the search term
            IEnumerable<DataRow> filteredRows = originalDataTable.AsEnumerable()
                .Where(row => row.ItemArray.Any(field => field.ToString().ToLower().Contains(searchTerm)));

            foreach (DataRow row in filteredRows)
            {
                filteredDataTable.ImportRow(row);
            }

            // Set the filtered DataTable as the DataGridView's data source
            dataGridView3.DataSource = filteredDataTable;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void widget3_Load(object sender, EventArgs e)
        {

        }
        private async void LoadData()
        {
            try
            {
                // Retrieve data from the API
                string response = await apiService.Get("/menu");

                // Convert the JSON response to a list of objects (assuming it's an array)
                GetMenuModel menuModel = JsonConvert.DeserializeObject<GetMenuModel>(response);
                List<Menu> menuList = menuModel.data.ToList();
                // Create a DataTable to hold the data
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ID", typeof(int));
                dataTable.Columns.Add("Nama", typeof(string));
                dataTable.Columns.Add("Tipe", typeof(string));
                dataTable.Columns.Add("Harga", typeof(string));
                // Add the data to the DataTable
                foreach (Menu menu in menuList)
                {
                    dataTable.Rows.Add(menu.id, menu.name, menu.menu_type, "Rp " + menu.price);
                }

                dataGridView3.DataSource = dataTable;
                originalDataTable = dataTable.Copy();
                dataGridView3.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                // Handle any exception that occurred during the API request
                MessageBox.Show("An error occurred while retrieving data: " + ex.Message);
            }
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the selected row

                // Show the details form and pass the data
                addCartForm addCartForm = new addCartForm();
                addCartForm.ShowDialog(); // Show the form as a modal dialog
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
