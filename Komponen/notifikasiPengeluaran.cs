using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using InTheHand.Net;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;

namespace KASIR.Komponen
{
    public partial class notifikasiPengeluaran : Form
    {
        private successTransaction SuccessTransaction { get; set; }
        private List<CartDetailTransaction> item = new List<CartDetailTransaction>();
        private List<RefundModel> refundItems = new List<RefundModel>();
        private readonly string MacAddressKasir;
        private readonly string PinPrinterKasir;
        private readonly string BaseOutletName;
        public bool ReloadDataInBaseForm { get; private set; }
        //public bool KeluarButtonPrintReportShiftClicked { get; private set; }
        private readonly string baseOutlet;
        GetTransactionDetail dataTransaction;
        public notifikasiPengeluaran(successTransaction successTransaction)
        {
            SuccessTransaction = successTransaction;
            PinPrinterKasir = Properties.Settings.Default.PinPrinterKasir;
            MacAddressKasir = Properties.Settings.Default.MacAddressKasir;
            baseOutlet = Properties.Settings.Default.BaseOutlet;
            BaseOutletName = Properties.Settings.Default.BaseOutletName;

            InitializeComponent();
            txtNotes.PlaceholderText = "Tujuan Pengeluaran?";


        }


        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // KeluarButtonPrintReportShiftClicked = true;
            this.Close();
        }
        private void AddItem(string name, string amount)
        {


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {

            if (txtNominal.Text == null || txtNominal.Text.ToString() == "")
            {
                MessageBox.Show("Format nominal kurang tepat", "Gaspol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtNotes.Text == null || txtNotes.Text.ToString() == "")
            {
                MessageBox.Show("Format notes kurang tepat", "Gaspol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var json = new
            {
                nominal = txtNominal.Text.ToString(),
                description = txtNotes.Text.ToString(),
                outlet_id = baseOutlet
            };

            string jsonString = JsonConvert.SerializeObject(json, Formatting.Indented);

            IApiService apiService = new ApiService();

            HttpResponseMessage response = await apiService.notifikasiPengeluaran(jsonString, "/expenditure");

            if (response != null)
            {
                if (response.IsSuccessStatusCode)
                {
                    DialogResult result = MessageBox.Show("Input notifikasi pengeluaran berhasil", "Gaspol", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        ReloadDataInBaseForm = true;
                        SuccessTransaction?.LoadData();
                        this.Close(); // Close the payForm
                    }
                    this.DialogResult = result;
                }
                else
                {
                    MessageBox.Show("Input notifikasi pengeluaran gagal  " + response.StatusCode);
                }
            }

        }

        private void txtJumlahCicil_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void txtSelesaiShift_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

