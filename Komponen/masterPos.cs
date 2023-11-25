using KASIR.Komponen;
using KASIR.Model;
using KASIR.Network;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Menu = KASIR.Model.Menu;


namespace KASIR.komponen
{
    public partial class masterPos : Form
    {
        private payForm _payForm;
        int jenisColumnIndex = -1;
        private ApiService apiService;
        private DataTable originalDataTable;
        string totalCart;
        string cartID;
        string customer_name;
        string customer_seat;
        private readonly string baseOutlet;
        private readonly string baseUrl;
        private BindingSource bindingSource = new BindingSource();
        private DataTable dataTable2;
        List<DataDiscountCart> dataDiscountListCart;
        int subTotalPrice;
        // List<DataTable> dataList;
        Dictionary<Menu, Image> menuImageDictionary = new Dictionary<Menu, Image>();
        public bool ReloadDataInBaseForm { get; private set; }

        public masterPos()
        {
            baseOutlet = Properties.Settings.Default.BaseOutlet;
            baseUrl = Properties.Settings.Default.BaseAddress;
            InitializeComponent();
            InitializeComboBox();
            apiService = new ApiService();
            panel8.Margin = new Padding(0, 0, 0, 0);       // No margin at the bottom
            dataGridView3.Margin = new Padding(0, 0, 0, 0);
            LoadData();
            //LoadCart();
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;

            bindingSource.DataSource = dataTable2;

            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.DrawMode = DrawMode.OwnerDrawVariable;
            cmbFilter.DrawItem += CmbFilter_DrawItem;

            cmbFilter.ItemHeight = 25;
           // InitializePayForm();
        }

      

        private void PayForm_KeluarButtonClicked(object sender, EventArgs e)
        {
            // Refresh the data when the Keluar button in payForm is clicked
            LoadData();
        }
        private void InitializeComboBox()
        {
            cmbFilter.Items.Add("Semua");
            cmbFilter.Items.Add("Makanan");
            cmbFilter.Items.Add("Minuman");
            cmbFilter.Items.Add("Additional Makanan");
            cmbFilter.Items.Add("Additional Minuman");
  /*          cmbFilter.Items.Add("Dessert");*/

        }

        private void CmbFilter_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.DrawBackground();

                int verticalMargin = 5;
                string itemText = cmbFilter.GetItemText(cmbFilter.Items[e.Index]);

                e.Graphics.DrawString(itemText, e.Font, Brushes.Black, new Rectangle(e.Bounds.Left, e.Bounds.Top + verticalMargin, e.Bounds.Width, e.Bounds.Height - verticalMargin));

                e.DrawFocusRectangle();
            }
        }

        private async void LoadDataDiscount()
        {
            try
            {
                IApiService apiService = new ApiService();
                string response = await apiService.GetDiscount("/discount?is_discount_cart=", "1");
                DiscountCartModel menuModel = JsonConvert.DeserializeObject<DiscountCartModel>(response);
                List<DataDiscountCart> data = menuModel.data;
                var options = data;
                dataDiscountListCart = data;
                options.Insert(0, new DataDiscountCart { id = -1, code = "Pilih Diskon" });
                cmbDiskon.DataSource = options;
                cmbDiskon.DisplayMember = "code";
                cmbDiskon.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal tampil data diskon " + ex.Message);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCariMenu_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void PerformSearch()
        {
            string searchQuery = txtCariMenu.Text.ToLower();

            // Iterate through the items in FlowLayoutPanel and filter based on search query
            foreach (Control control in dataGridView3.Controls)
            {
                if (control is Panel tileButton && control.Controls.Count >= 2)
                {
                    Label nameLabel = control.Controls[1] as Label;
                    if (nameLabel != null)
                    {
                        string itemName = nameLabel.Text.ToLower();

                        // Determine whether to show or hide the item based on the search query
                        bool showItem = string.IsNullOrEmpty(searchQuery) || itemName.Contains(searchQuery);
                        control.Visible = showItem;
                    }
                }
            }
            /*
             * if (originalDataTable == null)
                return;
             * DataTable filteredDataTable = originalDataTable.Clone();

            IEnumerable<DataRow> filteredRows = originalDataTable.AsEnumerable()
                .Where(row => row.ItemArray.Any(field => field.ToString().ToLower().Contains(searchTerm)));

            foreach (DataRow row in filteredRows)
            {
                filteredDataTable.ImportRow(row);
            }*/
            //dataGridView3.DataSource = filteredDataTable;
        }

        private async void button5_ClickAsync(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cartID))
            {
                MessageBox.Show("Keranjang masih kosong ");
                return;
            }
            else
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

                using (deleteForm deleteForm = new deleteForm(cartID.ToString()))
                {
                    deleteForm.Owner = background;

                    background.Show();

                    DialogResult dialogResult = deleteForm.ShowDialog();

                    background.Dispose();

                    if (dialogResult == DialogResult.OK && deleteForm.ReloadDataInBaseForm)
                    {
                        ReloadCart();
                    }
                }
            }
            
            /*
            DialogResult result = MessageBox.Show("Hapus Seluruh Pesanan?", "Gaspol", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                IApiService apiService = new ApiService();
                HttpResponseMessage response = await apiService.DeleteCart("/cart?outlet_id=" + baseOutlet);
                if (response != null)
                {
                    if (response.IsSuccessStatusCode)
                    {

                        this.DialogResult = result;
                        lblDiskon1.Text = "Rp. 0";
                        lblSubTotal1.Text = "Rp. 0";
                        lblTotal1.Text = "Rp. 0";
                        button1.Text = "Bayar ";
                        subTotalPrice = 0;
                        ReloadData();
                    }
                }
                ReloadDataInBaseForm = true;

            }
            else
            {

            }
*/
        }

        public async void LoadData()
        {
            try
            {
                string response = await apiService.Get("/menu?outlet_id=" + baseOutlet);

                GetMenuModel menuModel = JsonConvert.DeserializeObject<GetMenuModel>(response);
                List<Menu> menuList = menuModel.data.ToList();
                dataGridView3.Controls.Clear();
                foreach (Menu menu in menuList)
                {
                    Panel tileButton = new Panel();
                    tileButton.Width = 100;
                    tileButton.Height = 100;

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Dock = DockStyle.Fill;
                    tileButton.Controls.Add(pictureBox);

                    Label nameLabel = new Label();
                    nameLabel.Text = menu.name;
                    nameLabel.Dock = DockStyle.Bottom;
                    nameLabel.TextAlign = ContentAlignment.MiddleCenter;
                    tileButton.Controls.Add(nameLabel);

                    Label typeLabel = new Label();
                    typeLabel.Text = menu.menu_type;
                    typeLabel.Dock = DockStyle.Bottom;
                    typeLabel.TextAlign = ContentAlignment.MiddleCenter;
                    tileButton.Controls.Add(typeLabel);

                    typeLabel.Visible = false;

                    pictureBox.Click += async (sender, e) =>
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

                        using (addCartForm addCartForm = new addCartForm(menu.id.ToString()))
                        {
                            addCartForm.Owner = background;

                            background.Show();

                            DialogResult dialogResult = addCartForm.ShowDialog();

                            background.Dispose();

                            if (dialogResult == DialogResult.OK && addCartForm.ReloadDataInBaseForm)
                            {
                                LoadCart();
                            }
                        }
                    };

                    dataGridView3.Controls.Add(tileButton);

                    if (!menuImageDictionary.ContainsKey(menu))
                    {
                        menuImageDictionary.Add(menu, LoadPlaceholderImage(70, 70));

                        Task<Image> loadImageTask = LoadImageAsync(menu);
                        loadImageTask.ContinueWith(t =>
                        {
                            if (t.Status == TaskStatus.RanToCompletion)
                            {
                                menuImageDictionary[menu] = t.Result;
                                if (pictureBox.IsHandleCreated)
                                {
                                    pictureBox.BeginInvoke((Action)(() =>
                                    {
                                        pictureBox.Image = t.Result;
                                    }));
                                }
                            }
                        }, TaskScheduler.FromCurrentSynchronizationContext());
                    }
                    else
                    {
                        pictureBox.Image = menuImageDictionary[menu];
                    }
                }

                dataGridView3.AutoScroll = true;
                LoadCart();
                cmbFilter.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving data: " + ex.Message);
            }
        }

        private async Task<Image> LoadImageAsync(Menu menu)
        {
            try
            {
                string imageUrl = baseUrl+"/" + menu.image_url;

                using (WebClient client = new WebClient())
                {
                    byte[] imageData = await client.DownloadDataTaskAsync(imageUrl);
                    using (MemoryStream stream = new MemoryStream(imageData))
                    {
                        return Image.FromStream(stream);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error downloading image: {ex.Message}");
                return LoadPlaceholderImage(70, 70);
            }
        }

        // Method to asynchronously load the image
        private Image LoadPlaceholderImage(int width, int height)
        {
            // Replace this with your placeholder image logic
            // For example:
            Bitmap placeholder = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(placeholder))
            {
                graphics.FillRectangle(Brushes.Gray, 0, 0, width, height);
                graphics.DrawString("Image\nNot\nAvailable", SystemFonts.DefaultFont, Brushes.White, new PointF(10, 30));
            }
            return placeholder;
        }
       

        public async void LoadCart()
        {
            try
            {
                string response = await apiService.Get("/cart?outlet_id=" + baseOutlet);
                if (!string.IsNullOrEmpty(response))
                {
                    GetCartModel dataModel = JsonConvert.DeserializeObject<GetCartModel>(response);

                    //txtTotal.Text = "Rp. " + dataModel.data.total.ToString();
                    if (dataModel.data.total == 0)
                    {
                        customer_seat = "";
                        customer_name = "";
                        lblDiskon1.Text = "Rp. 0";
                        lblSubTotal1.Text = "Rp. 0";
                        lblTotal1.Text = "Rp. 0";
                        button1.Text = "Bayar ";
                        subTotalPrice = 0;
                    }
                    else
                    {
                        customer_seat = dataModel.data.customer_seat.ToString();
                        customer_name = dataModel.data.customer_name.ToString();
                        int result = dataModel.data.total - dataModel.data.subtotal;
                        lblDiskon1.Text = "Rp. " + result.ToString();
                        subTotalPrice = dataModel.data.subtotal;
                        lblSubTotal1.Text = "Rp. " + dataModel.data.subtotal.ToString();
                        lblTotal1.Text = "Rp. " + dataModel.data.total.ToString();
                        button1.Text = "Bayar Rp. " + dataModel.data.total.ToString();
                    }

                    totalCart = dataModel.data.total.ToString();
                    cartID = dataModel.data.cart_id.ToString();
                    List<DetailCart> cartList = dataModel.data.cart_details;

                    Dictionary<string, List<DetailCart>> menuGroups = new Dictionary<string, List<DetailCart>>();

                    foreach (DetailCart menu in cartList)
                    {
                        if (!menuGroups.ContainsKey(menu.serving_type_name))
                        {
                            menuGroups[menu.serving_type_name] = new List<DetailCart>();
                        }
                        menuGroups[menu.serving_type_name].Add(menu);
                    }

                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("MenuID", typeof(string));
                    dataTable.Columns.Add("CartDetailID", typeof(int));
                    dataTable.Columns.Add("Jenis", typeof(string));
                    dataTable.Columns.Add("Menu", typeof(string));
                    dataTable.Columns.Add("Jumlah", typeof(string));
                    dataTable.Columns.Add("Total Harga", typeof(string));
                    dataTable.Columns.Add("Note", typeof(string));
                    string currentJenis = null;

                    foreach (var group in menuGroups)
                    {
                        dataTable.Rows.Add(null, null, null, group.Key + "s", null, null, null); // Add a separator row
                        foreach (DetailCart menu in group.Value)
                        {
                            dataTable.Rows.Add(menu.menu_id, menu.cart_detail_id, menu.serving_type_name, menu.menu_name + " " + menu.varian, "x" + menu.qty, "Rp " + menu.total_price, null);
                            if (!string.IsNullOrEmpty(menu.note_item))
                            {
                                dataTable.Rows.Add(null, null, null, "*catatan : " + menu.note_item, null, null, null);
                            }
                        }
                    }

                    dataGridView1.DataSource = dataTable;
                    dataTable2 = dataTable.Copy();
                    dataGridView1.Columns["MenuID"].Visible = false;
                    dataGridView1.Columns["CartDetailID"].Visible = false;
                    dataGridView1.Columns["Jenis"].Visible = false;
                    dataGridView1.Columns["Note"].Visible = false;
                    LoadDataDiscount();

                }
                else
                {
                    // Handle the 404 error here, for example:
                    MessageBox.Show("Data tidak ditemukan");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Gagal tampil data " + ex.Message);
            }
        }



        private void DataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void ReloadData()
        {
            LoadData();

        }
        public void ReloadData2()
        {
            LoadData();

        }

        private void ReloadCart()
        {
            cartID = null;
            totalCart = null;
            button1.Text = "Bayar";
            lblDiskon1.Text = null;
            lblSubTotal1.Text = null;
            lblTotal1.Text = null;
            dataGridView1.DataSource = null;

        }


        private void masterPos_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
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

            using (payForm payForm = new payForm(baseOutlet, cartID, totalCart, lblTotal1.Text.ToString(), customer_seat, customer_name,this))
            {
                payForm.Owner = background;

                background.Show();

                DialogResult dialogResult = payForm.ShowDialog();

                background.Dispose();

                if (dialogResult == DialogResult.OK && payForm.ReloadDataInBaseForm)
                {
                    ReloadCart();

                }
            }


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCariMenu_TextChanged_1(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                    int id = Convert.ToInt32(selectedRow.Cells["MenuID"].Value);
                    DataGridViewRow selectedRow2 = dataGridView1.Rows[e.RowIndex];
                    int cartdetailid = Convert.ToInt32(selectedRow2.Cells["CartDetailID"].Value);
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

                    using (updateCartForm updateCartForm = new updateCartForm(id.ToString(), cartdetailid.ToString()))
                    {
                        updateCartForm.Owner = background;

                        background.Show();

                        DialogResult dialogResult = updateCartForm.ShowDialog();

                        background.Dispose();

                        if (dialogResult == DialogResult.OK && updateCartForm.ReloadDataInBaseForm)
                        {
                            ReloadData();
                        }
                    }
                    //updateCartForm updateCartForm = new updateCartForm(id.ToString(), cartdetailid.ToString());
                    //updateCartForm.Show();
                }
                catch
                {
                    return;
                }

            }
        }



        private void button2_Click(object sender, EventArgs e)
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
            int rowCount = dataGridView1.RowCount;
            if (rowCount == 0)
            {
                MessageBox.Show("Keranjang masih kosong!", "Gaspol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (saveBill saveBill = new saveBill(cartID))
            {
                saveBill.Owner = background;

                background.Show();

                DialogResult dialogResult = saveBill.ShowDialog();

                background.Dispose();

                if (dialogResult == DialogResult.OK && saveBill.ReloadDataInBaseForm)
                {
                    ReloadCart();
                }
            }
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            int selectedVarian = int.Parse(cmbDiskon.SelectedValue.ToString());
            if (selectedVarian == -1)
            {
                MessageBox.Show("Diskon belum dipilih !", "Gaspol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (selectedVarian != -1)
            {
                int diskonMinimum = dataDiscountListCart.FirstOrDefault(d => d.id == selectedVarian)?.min_purchase ?? -1;
                if (diskonMinimum > subTotalPrice)
                {
                    int resultDiskon = diskonMinimum - subTotalPrice;
                    MessageBox.Show("Minimum diskon kurang Rp " + resultDiskon + " lagi", "Gaspol");
                    return;
                }
            }
            try
            {

                
                var json = new
                {
                    cart_id = cartID,
                    discount_id = int.Parse(selectedVarian.ToString()),

                };
                string jsonString = JsonConvert.SerializeObject(json, Formatting.Indented);
                IApiService apiService = new ApiService();
                HttpResponseMessage response = await apiService.PayBill(jsonString, "/discount-transaction");
                if (response != null)
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        PostModel responseModel = JsonConvert.DeserializeObject<PostModel>(responseContent);

                        MessageBox.Show(responseModel.message, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        PostModel responseModel = JsonConvert.DeserializeObject<PostModel>(responseContent);
                        MessageBox.Show(responseModel.message, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menggunakan diskon: " + ex.Message, "Gaspol");
            }
        }

        private void lblSubTotal1_Click(object sender, EventArgs e)
        {

        }


        private void listBill_Click(object sender, EventArgs e)
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

            using (dataBill dataBill = new dataBill())
            {
                dataBill.Owner = background;

                background.Show();

                DialogResult dialogResult = dataBill.ShowDialog();

                background.Dispose();

                if (dialogResult == DialogResult.OK && dataBill.ReloadDataInBaseForm)
                {
                    ReloadData();
                }
            }


        }

        private void FilterMenuItems(string selectedMenuType)
        {
            // Iterate through the FlowLayoutPanel's controls and set their visibility based on the selected menu type
            foreach (Control control in dataGridView3.Controls)
            {
                if (control is Panel tileButton)
                {
                    Label typeLabel = tileButton.Controls.OfType<Label>().FirstOrDefault(label => label.Name == "typeLabel");
                    if (typeLabel != null)
                    {
                        // Check if the selected menu type matches the typeLabel's text or if "Semua" is selected
                        bool showItem = selectedMenuType == "Semua" || typeLabel.Text == selectedMenuType;
                        tileButton.Visible = showItem;
                    }
                }
            }
        }

        private async void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbFilter.SelectedItem != null)
            //{
            string selectedFilter = cmbFilter.SelectedItem.ToString();

            // Iterate through the items in FlowLayoutPanel and filter based on menu_type
            foreach (Control control in dataGridView3.Controls)
            {
                if (control is Panel tileButton && control.Controls.Count >= 3)
                {
                    Label typeLabel = control.Controls[2] as Label;
                    if (typeLabel != null)
                    {
                        string menuType = typeLabel.Text;

                        // Determine whether to show or hide the item based on the filter
                        bool showItem = (selectedFilter == "Semua" || selectedFilter == menuType);
                        control.Visible = showItem;
                    }
                }
            }




        }

        private void lblTotal1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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

            using (dataDiskon dataDiskon = new dataDiskon())
            {
                dataDiskon.Owner = background;

                background.Show();

                DialogResult dialogResult = dataDiskon.ShowDialog();

                background.Dispose();

                if (dialogResult == DialogResult.OK && dataDiskon.ReloadDataInBaseForm)
                {
                    ReloadData();
                }
            }
        }

        private void cmbDiskon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        /*private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Check if it's an image column (replace "ImageColumnName" with your actual column name or index)
                if (dataGridView3.Columns[e.ColumnIndex].Name == "Image")
                {
                    // Set the content alignment to center
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            /*if (e.RowIndex >= 0 && e.RowIndex < dataGridView3.Rows.Count)
            {
                DataGridViewRow row = dataGridView3.Rows[e.RowIndex];
                if (!row.Visible)
                {
                    e.Value = null;
                    e.FormattingApplied = true;
                }
            }
        }*/


    }
}
