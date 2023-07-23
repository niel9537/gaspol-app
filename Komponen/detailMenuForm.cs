using KASIR.komponen;
using KASIR.Model;
using KASIR.Network;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace KASIR.komponen
{
    public partial class detailMenuForm : Form
    {
        private List<string> namaVarian = new List<string>();
        private List<string> hargaVarian = new List<string>();
        public string idmenu;
        public detailMenuForm(string id)
        {
            InitializeComponent();
            LoadTipe();

            flowVarian.FlowDirection = FlowDirection.TopDown;
            flowVarian.WrapContents = false;
            flowVarian.AutoScroll = true;
            cmbTipe.Items.Add("Silahkan pilih tipe menu");
            cmbTipe.SelectedIndex = 2;
            cmbTipe.ForeColor = Color.Gray;
           idmenu = id;
            LoadDataAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void LoadTipe()
        {
            // Simulate loading categories from a data source
            string[] tipe = { "Makanan", "Minuman" };

            //Populate the ComboBox with categories
            cmbTipe.Items.AddRange(tipe);
        }
        private async void LoadDataAsync()
        {
                IApiService apiService = new ApiService();
                // Retrieve data from the API
                string response = await apiService.GetMenuByID("/menu",idmenu);

                // Convert the JSON response to a list of objects (assuming it's an array)
                GetMenuByIdModel menuModel = JsonConvert.DeserializeObject<GetMenuByIdModel>(response);
                DataMenu data = menuModel.data;
                // Create a DataTable to hold the data
                txtNama.Text = data.name;
               
        }

        private void btnTambah_Click_1(object sender, EventArgs e)
        {
            // Create a new Panel to hold two TextBoxes
            Panel newGroup = new Panel
            {
                Width = 560, // Adjust the width as needed
                Height = 60  // Adjust the height as needed
            };

            // Create two TextBoxes

            TextBox textBox1 = new TextBox { Width = 560, PlaceholderText = "Nama Varian ke " + (flowVarian.Controls.Count + 1) };
            TextBox textBox2 = new TextBox { Width = 560, Top = textBox1.Height + 5, PlaceholderText = "Harga Varian ke " + (flowVarian.Controls.Count + 1) };

            // Add the TextBoxes to the Panel
            newGroup.Controls.Add(textBox1);
            newGroup.Controls.Add(textBox2);

            // Add the Panel (group) to the FlowLayoutPanel
            flowVarian.Controls.Add(newGroup);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button4_Click_1(object sender, EventArgs e)
        {
            namaVarian.Clear();
            hargaVarian.Clear();

            // Validation flag to check if any textbox is empty
            bool anyEmptyTextBox = false;

            // Loop through all the Panels (groups) in the FlowLayoutPanel
            foreach (Control group in flowVarian.Controls)
            {
                if (group is Panel panel && panel.Controls.Count >= 2)
                {
                    // Get the first TextBox (textBox1) and add its value to textBox1Values list
                    if (panel.Controls[0] is TextBox textBox1)
                    {
                        if (string.IsNullOrWhiteSpace(textBox1.Text))
                        {
                            anyEmptyTextBox = true;
                            textBox1.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            namaVarian.Add(textBox1.Text);
                            textBox1.BackColor = System.Drawing.SystemColors.Window;
                        }
                    }

                    // Get the second TextBox (textBox2) and try to parse its value as a float (nullable)
                    if (panel.Controls[1] is TextBox textBox2)
                    {
                        if (string.IsNullOrWhiteSpace(textBox2.Text))
                        {
                            anyEmptyTextBox = true;
                            textBox2.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            hargaVarian.Add(textBox2.Text);
                            textBox2.BackColor = System.Drawing.SystemColors.Window;
                        }
                    }
                }
            }

            // Show warning if any textbox is empty
            if (anyEmptyTextBox)
            {
                MessageBox.Show("Please fill all textboxes before proceeding.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Show warning if any textbox is empty
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Please fill all textboxes before proceeding.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtHarga.Text))
            {
                MessageBox.Show("Please fill all textboxes before proceeding.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Check if the user has selected the "Please select" item
            if (cmbTipe.SelectedIndex == 2)
            {
                MessageBox.Show("Please select a menu type before proceeding.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            /*   string valuesMessage1 = "Values for TextBox1:\n" + string.Join("\n", namaVarian);
               string valuesMessage2 = "Values for TextBox2:\n" + string.Join("\n", hargaVarian);
               MessageBox.Show(valuesMessage1 + "\n\n" + valuesMessage2);*/

            List<Dictionary<string, object>> menuDetailsList = new List<Dictionary<string, object>>();

            // Loop through the collected values in textBox1Values and textBox2Values lists
            for (int i = 0; i < namaVarian.Count; i++)
            {
                string varian = namaVarian[i];
                string price = hargaVarian[i];

                // Create a dictionary for each "varian" and "price" pair
                Dictionary<string, object> varianPricePair = new Dictionary<string, object>
                {
                    { "varian", varian },
                    { "price", price }
                };

                // Add the dictionary to the menuDetailsList
                menuDetailsList.Add(varianPricePair);
            }

            // Create the main JSON object
            var json = new
            {
                name = txtNama.Text,
                menu_type = cmbTipe.Text,
                price = txtHarga.Text,
                menu_details = menuDetailsList
            };

            // Convert the JSON object to a JSON string
            string jsonString = JsonConvert.SerializeObject(json, Formatting.Indented);

         
            IApiService apiService = new ApiService();

            // Send the POST request with the JSON string as the raw JSON body
            HttpResponseMessage response = await apiService.PostAddMenu(jsonString, "/menu");

            if (response != null)
            {
                if (response.IsSuccessStatusCode)
                {
                    // Request succeeded
                    MessageBox.Show("Request succeeded! Status code: " + response.StatusCode);
                }
                else
                {
                    // Request failed
                    MessageBox.Show("Request failed! Status code: " + response.StatusCode);
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowVarian_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {

        }
    }
}
