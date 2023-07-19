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

namespace KASIR.komponen
{
    public partial class masterMenu : UserControl
    {
        private ApiService apiService;
        public masterMenu()
        {
            InitializeComponent();
            // Create an instance of ApiService
            apiService = new ApiService();

            // Retrieve data from the API and bind it to the DataGridView
            LoadData();
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
                dataTable.Columns.Add("name", typeof(string));
                dataTable.Columns.Add("menu_type", typeof(string));

                // Add the data to the DataTable
                foreach (Menu menu in menuList)
                {
                    dataTable.Rows.Add(menu.name, menu.menu_type);
                }

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Handle any exception that occurred during the API request
                MessageBox.Show("An error occurred while retrieving data: " + ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            create1 c = new create1();



            c.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
