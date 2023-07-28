using KASIR.Komponen;
using KASIR.Model;
using KASIR.Network;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KASIR.komponen
{
    public partial class masterMenu : UserControl
    {
        private Panel blurOverlayPanel;
        private PictureBox pictureBoxBackground;
        private ApiService apiService;
        private DataTable originalDataTable;
        public masterMenu()
        {
            InitializeComponent();
            // Create an instance of ApiService
            apiService = new ApiService();

            // Retrieve data from the API and bind it to the DataGridView
            LoadData();

            blurOverlayPanel = new Panel();
            blurOverlayPanel.BackColor = Color.FromArgb(100, 0, 0, 0); // Semi-transparent black
            blurOverlayPanel.Dock = DockStyle.Fill;
            blurOverlayPanel.Visible = false; // The overlay is initially hidden
            this.Controls.Add(blurOverlayPanel);

            // Initialize the PictureBox to show the background screenshot
            pictureBoxBackground = new PictureBox();
            pictureBoxBackground.SizeMode = PictureBoxSizeMode.Zoom;
            blurOverlayPanel.Controls.Add(pictureBoxBackground);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Capture the screenshot of the form and set it as the PictureBox's image
            Bitmap screenshot = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(screenshot, new Rectangle(0, 0, this.Width, this.Height));
            pictureBoxBackground.Image = ApplyBlurEffect(screenshot, 8); // Adjust the blur intensity as needed
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

                dataGridView1.DataSource = dataTable;
                originalDataTable = dataTable.Copy();
                dataGridView1.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                // Handle any exception that occurred during the API request
                MessageBox.Show("An error occurred while retrieving data: " + ex.Message);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            blur background = new blur();
            createMenuForm uu = new createMenuForm();
            using (uu)
            {
                
                background.StartPosition = FormStartPosition.CenterScreen;
                background.FormBorderStyle = FormBorderStyle.None;
                background.Opacity = 0.7d;
                background.BackColor = Color.Black;
                background.WindowState = FormWindowState.Maximized;
                background.TopMost = true;
                background.Size = this.Size;
                background.Location = this.Location;
                background.ShowInTaskbar = false;
                background.Show();
                uu.Owner = background;
                uu.ShowDialog();
                background.Dispose();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Call the method to perform the search
            PerformSearch();
        }

        private void PerformSearch()
        {
            if (originalDataTable == null)
                return;

            string searchTerm = textBox1.Text.ToLower();

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
            dataGridView1.DataSource = filteredDataTable;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                // Show the details form and pass the data
                detailMenuForm detailForm = new detailMenuForm(id.ToString());
                detailForm.ShowDialog(); // Show the form as a modal dialog
            }
        }

        public Bitmap ApplyBlurEffect(Bitmap image, int blurAmount)
        {
            // Apply the Gaussian blur effect to the given image
            if (blurAmount < 1) blurAmount = 1;
            else if (blurAmount > 20) blurAmount = 20;

            Bitmap blurredImage = new Bitmap(image.Width, image.Height);

            using (Graphics graphics = Graphics.FromImage(blurredImage))
            {
                Rectangle rectangle = new Rectangle(0, 0, image.Width, image.Height);
                ImageAttributes imageAttributes = new ImageAttributes();

                ColorMatrix colorMatrix = new ColorMatrix();
                colorMatrix.Matrix33 = blurAmount / 20.0f;

                imageAttributes.SetColorMatrix(colorMatrix);

                graphics.DrawImage(image, rectangle, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
            }

            return blurredImage;
        }
    }
}
