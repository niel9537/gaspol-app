using KASIR.komponen;
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
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace KASIR.komponen
{
    public partial class addCartForm : Form
    {
        private List<Button> radioButtonsList = new List<Button>();
        string idmenu;
        private DataMenuDetail datas;
        public string btnServingType;
        public bool ReloadDataInBaseForm { get; private set; }
        private readonly string baseOutlet;
        List<MenuDetailDataCart> menuDetailDataCarts;
        List<DataDiscountCart> dataDiskonList;
        public addCartForm(string id)
        {
            baseOutlet = Properties.Settings.Default.BaseOutlet;
            InitializeComponent();
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
            // flowLayoutPanel1.AutoScroll = true;
            /* radioButtonsList.Add(btnDinein);
             radioButtonsList.Add(btnTakeaway);
             radioButtonsList.Add(btnDelivery);
             radioButtonsList.Add(btnGofood);
             radioButtonsList.Add(btnGrabFood);
             radioButtonsList.Add(btnShopeeFood);*/
            txtKuantitas.Text = "0";
            /*   btnDinein.Tag = "1";
               btnTakeaway.Tag = "2";
               btnDelivery.Tag = "3";
               btnGofood.Tag = "4";
               btnGrabFood.Tag = "5";
               btnShopeeFood.Tag = "6";*/
            idmenu = id;
            foreach (var button in radioButtonsList)
            {
                button.Click += RadioButton_Click;
            }
            cmbVarian.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVarian.DrawMode = DrawMode.OwnerDrawVariable;
            cmbVarian.DrawItem += CmbVarian_DrawItem;

            cmbVarian.ItemHeight = 25; // Set the desired item height


            cmbDiskon.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDiskon.DrawMode = DrawMode.OwnerDrawVariable;
            cmbDiskon.DrawItem += CmbDiskon_DrawItem;

            cmbDiskon.ItemHeight = 25; // Set the desired item height
            LoadDataVarianAsync();
            /* int newHeight = Screen.PrimaryScreen.WorkingArea.Height - 100;
             Height = newHeight;*/
        }

        private async void LoadDataVarianAsync()
        {
            try
            {
                IApiService apiService = new ApiService();
                string response = await apiService.GetMenuDetailByID("/menu-detail", idmenu);
                GetMenuDetailCartModel menuModel = JsonConvert.DeserializeObject<GetMenuDetailCartModel>(response);
                DataMenuDetail data = menuModel.data;

                var options = data.menu_details.Where(x => x.menu_detail_id != 0).ToList();
                options.Insert(0, new MenuDetailDataCart { index = -1, varian = "Pilih Varian" });
                cmbVarian.DataSource = options;
                cmbVarian.DisplayMember = "varian";
                cmbVarian.ValueMember = "menu_detail_id";
                menuDetailDataCarts = data.menu_details;

                datas = menuModel.data;
                LoadDataDiscount();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal tampil data " + ex.Message, "Gaspol");
            }

        }
        private async void LoadDataServingType()
        {
            try
            {
                IApiService apiService = new ApiService();
                string response = await apiService.GetMenuByID("/menu", idmenu);
                GetMenuByIdModel menuModel = JsonConvert.DeserializeObject<GetMenuByIdModel>(response);
                DataMenu data = menuModel.data;
                var options = data.serving_types;
                options.Insert(0, new ServingType { id = -1, name = "Pilih Tipe Serving" });
                comboBox1.DataSource = options;
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal tampil data tipe serving " + ex.Message, "Gaspol");
            }

        }
        private async Task<string> returnPriceByServingTypeAsync(string id, string varian)
        {
            IApiService apiService = new ApiService();
            string response = await apiService.GetMenuDetailByID("/menu-detail", "" + idmenu + "?menu_detail_id=" + varian);
            GetMenuDetailCartModel menuModel = JsonConvert.DeserializeObject<GetMenuDetailCartModel>(response);
            DataMenuDetail data = menuModel.data;
            List<MenuDetailDataCart> menuDetailDataList = data.menu_details;
            List<ServingTypes> servingTypes = menuDetailDataList[0].serving_types;
            var servingType = servingTypes.FirstOrDefault(serving => serving.id == int.Parse(id));
            if (servingType != null)
            {
                return servingType.price.ToString();
            }
            else
            {
                return "0";
            }
        }


        private string returnMenuDetailIdByIndex(string id, List<MenuDetailDataCart> dataDetail)
        {
            string result = "0";
            result = dataDetail[int.Parse(id)].menu_detail_id.ToString();
            return result;
        }
        private async void btnSimpan_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                int selectedVarian = int.Parse(cmbVarian.SelectedValue.ToString());
                int selectedDiskon = int.Parse(cmbDiskon.SelectedValue.ToString());
                int diskon = 0;
                if (comboBox1.Text.ToString() == "Pilih Tipe Serving")
                {
                    MessageBox.Show("Pilih tipe serving", "Gaspol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (int.Parse(txtKuantitas.Text.ToString()) <= 0 || txtKuantitas.Text.ToString() == "")
                {
                    MessageBox.Show("Masukan jumlah kuantitas!", "Gaspol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int serving_type = int.Parse(comboBox1.SelectedValue.ToString());
                var quantity = int.Parse(txtKuantitas.Text.ToString());
                var notes = txtNotes.Text.ToString();
                int? menuDetailIdValue = null;
                string pricefix = "0";

                if (selectedVarian == null || selectedVarian == -1)
                {
                    // MenuDetailDataCart paramData = menuDetailDataCarts[0];
                    pricefix = await returnPriceByServingTypeAsync(serving_type.ToString(), "0");
                }
                else
                {
                    // MenuDetailDataCart paramData = menuDetailDataCarts[selectedVarian];
                    pricefix = await returnPriceByServingTypeAsync(serving_type.ToString(), "" + selectedVarian);
                }
                if (selectedDiskon == -1)
                {
                    diskon = 0;
                }
                else
                {
                    diskon = selectedDiskon;
                    if (diskon != -1)
                    {
                        int diskonMinimum = dataDiskonList.FirstOrDefault(d => d.id == diskon)?.min_purchase ?? -1;
                        if (diskonMinimum > (int.Parse(pricefix) * quantity))
                        {
                            int resultDiskon = diskonMinimum - (int.Parse(pricefix) * quantity);
                            MessageBox.Show("Minimum diskon kurang Rp " + resultDiskon + " lagi", "Gaspol");
                            return;
                        }
                    }
                }

                Dictionary<string, object> json = new Dictionary<string, object>
                {
                    { "outlet_id", baseOutlet },
                    { "menu_id", datas.id },
                    { "serving_type_id", serving_type },
                    { "price", pricefix },
                    { "discount_id", diskon.ToString() },
                    { "qty", quantity },
                    { "note_item", notes }
                };
                if (selectedVarian != null && selectedVarian != -1)
                {
                    json["menu_detail_id"] = selectedVarian;
                    // Now you can use the selectedValueAsString as needed
                }
                string jsonString = JsonConvert.SerializeObject(json, Formatting.Indented);
                IApiService apiService = new ApiService();
                HttpResponseMessage response = await apiService.CreateCart(jsonString, "/cart");
                if (response != null)
                {
                    if (response.IsSuccessStatusCode)
                    {
                        DialogResult result = MessageBox.Show("Menu berhasil ditambahkan", "Gaspol", MessageBoxButtons.OK);

                        if (result == DialogResult.OK)
                        {
                            ReloadDataInBaseForm = true;

                        }
                        this.DialogResult = result;
                    }
                    else
                    {
                        MessageBox.Show("Menu gagal ditambahkan", "Gaspol");
                    }
                }
                else
                {
                    MessageBox.Show("Gagal tambah data " + response.ToString(), "Gaspol");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal tambah data " + ex.Message, "Gaspol");
            }

        }

        private void RadioButton_Click(object sender, EventArgs e)
        {
            var clickedButton = (Button)sender;

            foreach (var button in radioButtonsList)
            {

                button.BackColor = SystemColors.ControlDark;
            }

            clickedButton.ForeColor = Color.White;
            clickedButton.BackColor = Color.SteelBlue;

            btnServingType = clickedButton.Tag.ToString();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtKuantitas.Text, out int numericValue))
            {
                numericValue++;
                txtKuantitas.Text = numericValue.ToString();
            }
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtKuantitas.Text, out int numericValue))
            {
                if (numericValue > 1)
                {
                    numericValue--;
                    txtKuantitas.Text = numericValue.ToString();
                }
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShopeeFood_Click(object sender, EventArgs e)
        {

        }

        private void btnTakeaway_Click(object sender, EventArgs e)
        {

        }

        private void addCartForm_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void LoadDataDiscount()
        {
            try
            {
                IApiService apiService = new ApiService();
                string response = await apiService.GetDiscount("/discount?is_discount_cart=", "0");
                DiscountCartModel menuModel = JsonConvert.DeserializeObject<DiscountCartModel>(response);
                List<DataDiscountCart> data = menuModel.data;
                var options = data;
                dataDiskonList = data;
                options.Insert(0, new DataDiscountCart { id = -1, code = "Pilih Diskon" });
                cmbDiskon.DataSource = options;
                cmbDiskon.DisplayMember = "code";
                cmbDiskon.ValueMember = "id";
                LoadDataServingType();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal tampil data diskon " + ex.Message, "Gaspol");
            }

        }

        private void CmbVarian_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.DrawBackground();

                int verticalMargin = 5;
                string itemText = cmbVarian.GetItemText(cmbVarian.Items[e.Index]);

                e.Graphics.DrawString(itemText, e.Font, Brushes.Black, new Rectangle(e.Bounds.Left, e.Bounds.Top + verticalMargin, e.Bounds.Width, e.Bounds.Height - verticalMargin));

                e.DrawFocusRectangle();
            }
        }

        private void CmbDiskon_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.DrawBackground();

                int verticalMargin = 5;
                string itemText = cmbDiskon.GetItemText(cmbDiskon.Items[e.Index]);

                e.Graphics.DrawString(itemText, e.Font, Brushes.Black, new Rectangle(e.Bounds.Left, e.Bounds.Top + verticalMargin, e.Bounds.Width, e.Bounds.Height - verticalMargin));

                e.DrawFocusRectangle();
            }
        }

        private void cmbDiskon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
