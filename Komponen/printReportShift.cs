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
    public partial class printReportShift : Form
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
        public printReportShift(successTransaction successTransaction)
        {
            SuccessTransaction = successTransaction;
            PinPrinterKasir = Properties.Settings.Default.PinPrinterKasir;
            MacAddressKasir = Properties.Settings.Default.MacAddressKasir;
            baseOutlet = Properties.Settings.Default.BaseOutlet;
            BaseOutletName = Properties.Settings.Default.BaseOutletName;

            InitializeComponent();


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
            if (txtActualCash.Text.ToString() == ""|| txtActualCash.Text == null)
            {
                MessageBox.Show("Uang kasir masih kurang tepat", "Gaspol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!maskedTextBox.MaskCompleted)
            {
                MessageBox.Show("Format jam mulai kurang tepat", "Gaspol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Get the value without prompt characters
            string formattedTime = maskedTextBox.Text;
            formattedTime = formattedTime.Replace("_", "0"); // Replace underscores with zeros
            TimeSpan time;
            if (!TimeSpan.TryParseExact(formattedTime, "hh':'mm", CultureInfo.InvariantCulture, out time))
            {
                MessageBox.Show("Format jam mulai kurang tepat", "Gaspol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (time < TimeSpan.Zero || time > TimeSpan.FromHours(24))
            {
                MessageBox.Show("Jam harus dari rentang 00:00 dan 24:00.", "Gaspol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!maskedTextBox1.MaskCompleted)
            {
                MessageBox.Show("Format jam selesai kurang tepat", "Gaspol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Get the value without prompt characters
            string formattedTime1 = maskedTextBox1.Text;
            formattedTime1 = formattedTime1.Replace("_", "0"); // Replace underscores with zeros
            TimeSpan time1;
            if (!TimeSpan.TryParseExact(formattedTime1, "hh':'mm", CultureInfo.InvariantCulture, out time))
            {
                MessageBox.Show("Format jam selesai kurang tepat", "Gaspol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (time < TimeSpan.Zero || time > TimeSpan.FromHours(24))
            {
                MessageBox.Show("Jam harus dari rentang 00:00 dan 24:00.", "Gaspol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var json = new
            {
                start_time = maskedTextBox.Text.ToString(),
                end_time = maskedTextBox1.Text.ToString(),
                outlet_id = baseOutlet,
                actual_ending_cash = txtActualCash.Text.ToString()
            };

            string jsonString = JsonConvert.SerializeObject(json, Formatting.Indented);

            IApiService apiService = new ApiService();

            string response = await apiService.CetakLaporanShift(jsonString, "/struct-shift");

            if (response != null)
            {
               /* if (response.IsSuccessStatusCode)
                {
*/
                    //tempat struk

                GetStrukShift shifModel = JsonConvert.DeserializeObject<GetStrukShift>(response);
                DataStrukShift data = shifModel.data;
                List<ExpenditureStrukShift> listExpenditure = data.expenditures;
                List<CartDetailsSuccessStrukShift> listCartDetailsSuccessStrukShift = data.cart_details_success;
                List<CartDetailsPendingStrukShift> listCartDetailsPendingStrukShift = data.cart_details_pending;
                List<RefundDetailStrukShift> listRefundDetailStrukShift = data.refund_details;
                List<PaymentDetailStrukShift> listPaymentDetailStrukShift = data.payment_details;
                try
                {
                    DataStrukShift datas = shifModel.data;
                    List<ExpenditureStrukShift> expenditures = datas.expenditures;
                    List<CartDetailsSuccessStrukShift> cartDetailsSuccess = datas.cart_details_success;
                    List<CartDetailsPendingStrukShift> cartDetailsPending = datas.cart_details_pending;
                    List<RefundDetailStrukShift> refundDetails = datas.refund_details;
                    List<PaymentDetailStrukShift> paymentDetails = datas.payment_details;

                    PrintShiftReceipt(datas, expenditures, cartDetailsSuccess, cartDetailsPending, refundDetails, paymentDetails);

                    DialogResult result = MessageBox.Show("Cetak laporan sukses", "Gaspol", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        ReloadDataInBaseForm = true;
                        SuccessTransaction?.LoadData();
                        this.Close(); // Close the payForm
                    }
                    this.DialogResult = result;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error printing: " + ex.Message);
                }
  
              /*  }
                else
                {
                    MessageBox.Show("Cetak laporan gagal  " + response.StatusCode);
                }*/
            }

        }

        private string LeftingText(string param1, string param2)
        {
            // Menyusun teks dengan parameter 1, spasi, dan parameter 2
            string formattedText = $"{param1} {param2}";

            // Menentukan panjang spasi yang diperlukan untuk rata kiri (32 karakter)
            int paddingLength = Math.Max(0, 32 - formattedText.Length);

            // Format baris dengan padding dan alignment yang benar
            string result = formattedText.PadRight(paddingLength);

            return result;
        }

        // Fungsi untuk mengatur teks di tengah
        private string CenterText(string text)
        {
            int spaces = Math.Max(0, (32 - text.Length) / 2);
            return new string(' ', spaces) + text;
        }

        // Fungsi untuk memformat baris dengan dua kolom (key, value)
        private string FormatSimpleLine(string left, object right)
        {
            // Jika objek right null, maka atur rightString sebagai string kosong
            string rightString = right != null ? right.ToString() : string.Empty;

            // Hitung panjang teks yang seharusnya ditambahkan ke kiri
            int paddingLength = Math.Max(0, 32 - rightString.Length);

            // Format baris dengan padding dan alignment yang benar
            string formattedLine = left.PadRight(paddingLength) + rightString;

            return formattedLine;
        }

        private void PrintShiftReceipt(DataStrukShift datas, List<ExpenditureStrukShift> expenditures, List<CartDetailsSuccessStrukShift> cartDetailsSuccess, List<CartDetailsPendingStrukShift> cartDetailsPendings, List<RefundDetailStrukShift> refundDetails, List<PaymentDetailStrukShift> paymentDetails)
        {
            BluetoothDeviceInfo printer = new BluetoothDeviceInfo(BluetoothAddress.Parse(MacAddressKasir));
            if (printer == null)
            {
                MessageBox.Show("Printer" + MacAddressKasir + "not found.", "Gaspol");
                return;
            }

            BluetoothClient client = new BluetoothClient();
            BluetoothEndPoint endpoint = new BluetoothEndPoint(printer.DeviceAddress, BluetoothService.SerialPort);

            using (BluetoothClient clientSocket = new BluetoothClient())
            {
                if (!BluetoothSecurity.PairRequest(printer.DeviceAddress, PinPrinterKasir))
                {
                    MessageBox.Show("Pairing failed to " + MacAddressKasir, "Gaspol");
                    return;
                }
                clientSocket.Connect(endpoint);
                System.IO.Stream stream = clientSocket.GetStream();

                // Custom variable
                string kodeHeksadesimalBold = "\x1B\x45\x01";
                string kodeHeksadesimalSizeBesar = "\x1D\x21\x01";
                string kodeHeksadesimalNormal = "\x1B\x45\x00" + "\x1D\x21\x00";

                // Struct template
                string strukText = "\n" + CenterText(datas.outlet_name) + "\n";
                strukText += CenterText(datas.outlet_address) + "\n";
                strukText += CenterText(datas.outlet_phone_number) + "\n";
                strukText += "--------------------------------\n";
                strukText += kodeHeksadesimalSizeBesar + CenterText("SHIFT PRINT") + "\n";
                strukText += kodeHeksadesimalNormal;
                strukText += "--------------------------------\n";
                strukText += FormatSimpleLine("Start Date", datas.start_date) + "\n";
                strukText += FormatSimpleLine("End Date", datas.end_date) + "\n";
                strukText += FormatSimpleLine("Sold Items", datas.items_sold) + "\n";
                strukText += FormatSimpleLine("Refunded Items", datas.items_refunded) + "\n";
                strukText += "--------------------------------\n";
                strukText += kodeHeksadesimalBold + CenterText("ORDER DETAILS") + "\n";
                strukText += kodeHeksadesimalNormal;
                strukText += "--------------------------------\n";
                strukText += kodeHeksadesimalBold + LeftingText("SOLD ITEMS", "") + "\n";
                strukText += kodeHeksadesimalNormal;
                foreach (var cartDetail in cartDetailsSuccess)
                {
                    strukText += LeftingText(cartDetail.menu_name, cartDetail.varian) + "\n";
                    strukText += FormatSimpleLine(cartDetail.qty.ToString(), cartDetail.total_price) + "\n";
                }
                if(cartDetailsPendings.Count != 0)
                {
                    strukText += "--------------------------------\n";
                    strukText += kodeHeksadesimalBold + LeftingText("PENDING ITEMS", "") + "\n";
                    strukText += kodeHeksadesimalNormal;
                    foreach (var cartDetail in cartDetailsPendings)
                    {
                        strukText += LeftingText(cartDetail.menu_name, cartDetail.varian) + "\n";
                        strukText += FormatSimpleLine(cartDetail.qty.ToString(), cartDetail.total_price) + "\n";
                    }
                }
                if (refundDetails.Count != 0)
                {
                    strukText += "--------------------------------\n";
                    strukText += kodeHeksadesimalBold + LeftingText("REFUND ITEMS", "") + "\n";
                    strukText += kodeHeksadesimalNormal;
                    foreach (var cartDetail in refundDetails)
                    {
                        strukText += LeftingText(cartDetail.menu_name, cartDetail.varian) + "\n";
                        strukText += FormatSimpleLine(cartDetail.qty_refund_item.ToString(), cartDetail.total_refund_price) + "\n";
                    }
                }
                strukText += "--------------------------------\n";
                strukText += FormatSimpleLine("TOTAL AMOUNT", datas.items_total_amount) + "\n";
                strukText += "--------------------------------\n";
                strukText += kodeHeksadesimalBold + LeftingText("DISCOUNTS", "") + "\n";
                strukText += kodeHeksadesimalNormal;
                strukText += FormatSimpleLine("DISCOUNT CARTS", datas.discount_amount_transactions) + "\n";
                strukText += FormatSimpleLine("DISCOUNT PER ITEMS", datas.discount_amount_per_items) + "\n";
                strukText += FormatSimpleLine("TOTAL AMOUNT", datas.discount_total_amount) + "\n";
                strukText += "--------------------------------\n";
                strukText += kodeHeksadesimalBold + CenterText("CASH MANAGEMENT") + "\n";
                strukText += kodeHeksadesimalNormal;
                strukText += "--------------------------------\n";
                strukText += FormatSimpleLine("Cash Payment", datas.items_total_amount) + "\n";
                if (expenditures.Count != 0)
                {
                    strukText += kodeHeksadesimalBold + LeftingText("EXPENSE", "") + "\n";
                    strukText += kodeHeksadesimalNormal;
                    foreach (var expense in expenditures)
                    {
                        strukText += FormatSimpleLine(expense.description, expense.nominal) + "\n";
                    }
                }
                strukText += FormatSimpleLine("Expected Ending Cash", datas.ending_cash_expected) + "\n";
                strukText += FormatSimpleLine("Actual Ending Cash", datas.ending_cash_actual) + "\n";
                strukText += FormatSimpleLine("Cash Difference", datas.cash_difference) + "\n";
                strukText += "--------------------------------\n";
                strukText += kodeHeksadesimalBold + CenterText("PAYMENT DETAIL") + "\n";
                strukText += kodeHeksadesimalNormal;
                strukText += "--------------------------------\n";
                foreach(var paymentDetail in paymentDetails)
                {
                    strukText += kodeHeksadesimalBold + LeftingText(paymentDetail.payment_category, "") + "\n";
                    strukText += kodeHeksadesimalNormal;
                    foreach (var paymentType in paymentDetail.payment_type_detail)
                    {
                        strukText += FormatSimpleLine(paymentType.payment_type, paymentType.total_payment) + "\n";
                    }
                    strukText += LeftingText("TOTAL AMOUNT", paymentDetail.total_amount.ToString()) + "\n";
                    strukText += "--------------------------------\n";
                }
                strukText += kodeHeksadesimalBold + FormatSimpleLine("TOTAL TRANSACTION", datas.total_transaction) + "\n";
                strukText += kodeHeksadesimalNormal + "\n\n\n\n\n";

                // Iterate through cart details and group by serving_type_name
                var servingTypes = cartDetailsSuccess.Select(cd => cd.serving_type_name).Distinct();

                // Encode your text into bytes (you might need to adjust the encoding)
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(strukText);

                // Send the text to the printer
                stream.Write(buffer, 0, buffer.Length);

                // Flush the stream to ensure all data is sent to the printer
                stream.Flush();

                // Close the stream and disconnect
                clientSocket.GetStream().Close();
                stream.Close();
                clientSocket.Close();
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

        private void txtSelesaiShift_TextChanged_1(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            string input = textBox.Text.Replace(":", "");

            if (input.Length >= 2)
            {
                string hours = input.Substring(0, 2);
                int parsedHours;
                if (int.TryParse(hours, out parsedHours) && parsedHours >= 0 && parsedHours <= 24)
                {
                    string minutes = input.Substring(2).PadRight(2, '0').Substring(0, 2);
                    textBox.Text = $"{parsedHours:D2}:{minutes}";
                }
                else
                {
                    textBox.Text = "00:00";
                }
            }
        }

        private void txtMulaiShift_TextChanged(object sender, EventArgs e)
        {

            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            string input = textBox.Text.Replace(":", "");

            if (input.Length >= 2)
            {
                string hours = input.Substring(0, 2);
                int parsedHours;
                if (int.TryParse(hours, out parsedHours) && parsedHours >= 0 && parsedHours <= 24)
                {
                    string minutes = input.Substring(2).PadRight(2, '0').Substring(0, 2);
                    textBox.Text = $"{parsedHours:D2}:{minutes}";
                }
                else
                {
                    textBox.Text = "00:00";
                }
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }

}

