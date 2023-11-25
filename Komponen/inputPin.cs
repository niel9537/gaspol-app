using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using InTheHand.Net;
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
    public partial class inputPin : Form
    {
        private readonly string baseOutlet;
        private readonly string MacAddressKasir;
        private readonly string MacAddressKitchen;
        private readonly string MacAddressBar;
        private readonly string PinPrinterKasir;
        private readonly string PinPrinterKitchen;
        private readonly string PinPrinterBar;
        private readonly string BaseOutletName;
        int idid;
        public bool ReloadDataInBaseForm { get; private set; }
        public inputPin(int id)
        {
            idid = id;
            baseOutlet = Properties.Settings.Default.BaseOutlet;
            MacAddressKasir = Properties.Settings.Default.MacAddressKasir;
            MacAddressKitchen = Properties.Settings.Default.MacAddressKitchen;
            MacAddressBar = Properties.Settings.Default.MacAddressBar;
            PinPrinterKasir = Properties.Settings.Default.PinPrinterKasir;
            PinPrinterKitchen = Properties.Settings.Default.PinPrinterKitchen;
            PinPrinterBar = Properties.Settings.Default.PinPrinterBar;
            BaseOutletName = Properties.Settings.Default.BaseOutletName;
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private async void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtPin.Text.ToString() == "" || txtPin.Text == null)
                {
                    MessageBox.Show("Masukan pin terlebih dahulu", "Gaspol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var json = new
                {
                    outlet_id = baseOutlet,
                    pin = txtPin.Text


                };
                string jsonString = JsonConvert.SerializeObject(json, Formatting.Indented);
                IApiService apiService = new ApiService();
                HttpResponseMessage response = await apiService.inputPin(jsonString, "/check-pin");
                if (response != null)
                {
                    if (response.IsSuccessStatusCode)
                    {
                        DialogResult result = MessageBox.Show("Autentikasi berhasil", "Gaspol", MessageBoxButtons.OK);
                        //ReloadDataInBaseForm = true;
                        this.Close();
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
                        using (refund refund = new refund(idid.ToString()))
                        {
                            refund.Owner = background;

                            background.Show();

                            DialogResult dialogResult = refund.ShowDialog();

                            background.Dispose();

                            if (dialogResult == DialogResult.Yes && refund.ReloadDataInBaseForm)
                            {
                                this.Close();
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Autentikasi gagal", "Gaspol", MessageBoxButtons.OK); ;
            }
        }

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

        // Fungsi untuk memformat baris dengan tiga kolom (Item, Kuantitas, Harga)
        private string FormatItemLine(string item, object quantity, object price)
        {
            int column1Width = 20; // Adjust as needed
            int column2Width = 6;  // Adjust as needed

            string quantityString = quantity.ToString() + "x ";
            string priceString = price.ToString();

            // Format the line with padding and alignment
            string formattedLine = "\x1B\x45\x01" + item.PadRight(column1Width) + "\x1B\x45\x00" +
                                   quantityString.PadLeft(column2Width) +
                                   priceString.PadLeft(priceString.Length);
            return formattedLine;
        }

        // Fungsi untuk memformat baris dengan dua kolom detail item
        private string FormatDetailItemLine(string column1, object column2)
        {
            // Gabungkan kolom menjadi satu string dengan format "column1: column2"
            string combinedColumns = column1 + ": " + column2.ToString();

            // Jika panjang kombinasi kolom lebih dari 32 karakter
            if (combinedColumns.Length > 32)
            {
                // Inisialisasi string untuk menyimpan hasil yang akan dikembalikan
                string formattedLine = "";

                // Hitung berapa karakter yang masih dapat dimasukkan ke baris ini
                int charactersToFitInLine = 32;

                // Indeks untuk memulai bagian berikutnya dari teks yang akan diproses
                int startIndex = 0;

                while (startIndex < combinedColumns.Length)
                {
                    // Bagian berikutnya dari teks yang akan diproses
                    string nextPart = combinedColumns.Substring(startIndex, Math.Min(charactersToFitInLine, combinedColumns.Length - startIndex));

                    // Tambahkan ke baris yang akan dikembalikan
                    formattedLine += nextPart;

                    // Periksa apakah masih ada lebih banyak teks yang harus diproses
                    if (startIndex + nextPart.Length < combinedColumns.Length)
                    {
                        // Tambahkan newline (\n) jika masih ada teks yang harus diproses
                        formattedLine += "\n";

                        // Sisakan karakter yang dapat dimasukkan ke baris berikutnya
                        charactersToFitInLine = 32;
                    }

                    // Perbarui indeks untuk memulai bagian berikutnya
                    startIndex += nextPart.Length;
                }

                return formattedLine;
            }
            else
            {
                // Jika panjang tidak melebihi 32 karakter, langsung lakukan padding
                int paddingSpaces = 32 - combinedColumns.Length;
                string formattedLine = "".PadLeft(paddingSpaces) + combinedColumns;
                return formattedLine;
            }
        }

        private string FormatKitchenBarLine(string left, object right)
        {
            // Jika objek right null, maka atur rightString sebagai string kosong
            string rightString = right.ToString();

            // Tambahkan tanda kurung buka dan tutup ke string "left"
            left = "( " + left + " )";

            // Gabungkan string "left" dengan string "right" tanpa spasi tambahan di antaranya
            string formattedLine = left + " " + rightString;

            return formattedLine;
        }

        // Struct Pembayaran
        private void PrintPurchaseReceipt(DataRestruk datas, List<CartDetailRestruk> cartDetails)
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
                string nomorMeja = "Meja No." + datas.customer_seat;

                // Struct template
                string strukText = "\n" + kodeHeksadesimalBold + CenterText(BaseOutletName) + "\n";
                strukText += kodeHeksadesimalNormal;
                strukText += "--------------------------------\n";

                strukText += kodeHeksadesimalSizeBesar + CenterText("Pembelian") + "\n";
                strukText += kodeHeksadesimalNormal;
                strukText += "--------------------------------\n";
                strukText += CenterText(datas.receipt_number) + "\n";
                strukText += FormatSimpleLine(datas.customer_name, nomorMeja) + "\n";

                // Iterate through cart details and group by serving_type_name
                var servingTypes = cartDetails.Select(cd => cd.serving_type_name).Distinct();

                foreach (var servingType in servingTypes)
                {
                    // Filter cart details by serving_type_name
                    var itemsForServingType = cartDetails.Where(cd => cd.serving_type_name == servingType).ToList();

                    // Skip if there are no items for this serving type
                    if (itemsForServingType.Count == 0)
                        continue;

                    // Add a section for the serving type
                    strukText += "--------------------------------\n";
                    strukText += CenterText(servingType) + "\n";
                    strukText += "--------------------------------\n";

                    // Iterate through items for this serving type
                    foreach (var cartDetail in itemsForServingType)
                    {
                        strukText += FormatItemLine(cartDetail.menu_name, cartDetail.qty, cartDetail.total_price) + "\n";
                        // Add detail items
                        if (!string.IsNullOrEmpty(cartDetail.varian))
                            strukText += FormatDetailItemLine("Varian", cartDetail.varian) + "\n";
                        if (!string.IsNullOrEmpty(cartDetail.note_item?.ToString()))
                            strukText += FormatDetailItemLine("Note", cartDetail.note_item) + "\n";
                        if (!string.IsNullOrEmpty(cartDetail.discount_code))
                            strukText += FormatDetailItemLine("Discount Code", cartDetail.discount_code) + "\n";
                        if (cartDetail.discounted_price != null)
                            strukText += FormatDetailItemLine("Total Discount", cartDetail.discounted_price) + "\n";

                        // Add an empty line between items
                        strukText += "\n";
                    }
                }
                strukText += "--------------------------------\n";
                strukText += FormatSimpleLine("Subtotal", datas.subtotal) + "\n";
                if (!string.IsNullOrEmpty(datas.discount_code))
                    strukText += FormatSimpleLine("Discount Code", datas.discount_code) + "\n";
                if (datas.discounts_value != null)
                    strukText += FormatSimpleLine("Discount Value", datas.discounts_value) + "\n";
                strukText += FormatSimpleLine("Total", datas.total) + "\n";
                strukText += FormatSimpleLine("Payment Type", datas.payment_type) + "\n";
                strukText += FormatSimpleLine("Cash", datas.customer_cash) + "\n";
                strukText += FormatSimpleLine("Change", datas.customer_change) + "\n";
                strukText += "--------------------------------\n";
                strukText += "Terima kasih atas kunjungan Anda\n\n\n\n\n";

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
        private async void btnCetakStruk_Click(object sender, EventArgs e)
        {
            try
            {
                IApiService apiService = new ApiService();
                string response = await apiService.Restruk("/transaction/" + idid + "?outlet_id=" + baseOutlet);
                if (response != null)
                {

                    RestrukModel restrukModel = JsonConvert.DeserializeObject<RestrukModel>(response);
                    DataRestruk data = restrukModel.data;
                    List<CartDetailRestruk> listCart = data.cart_details;
                    try
                    {
                        DataRestruk datas = restrukModel.data;
                        List<CartDetailRestruk> cartDetails = datas.cart_details;

                        PrintPurchaseReceipt(datas, cartDetails);

                        DialogResult result = MessageBox.Show("Cetak struk sukses", "Gaspol", MessageBoxButtons.OK);

                        if (result == DialogResult.OK)
                        {

                            ReloadDataInBaseForm = true;

                        }
                        this.DialogResult = result;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Gagal cetak ulang struk " + ex.Message);
                    }


                }
                else
                {
                    MessageBox.Show("Gagal cetak ulang struk " + response.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal cetak ulang struk " + ex.Message, "Gaspol");
            }

        }
    }
}
