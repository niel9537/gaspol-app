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

namespace KASIR.komponen
{
    public partial class saveBill : Form
    {
        string cart_id;
        int row;
        private readonly string baseOutlet;
        private readonly string MacAddressKasir;
        private readonly string MacAddressKitchen;
        private readonly string MacAddressBar;
        private readonly string PinPrinterKasir;
        private readonly string PinPrinterKitchen;
        private readonly string PinPrinterBar;
        private readonly string BaseOutletName;
        public bool ReloadDataInBaseForm { get; private set; }
        public saveBill(string cartId)
        {
            baseOutlet = Properties.Settings.Default.BaseOutlet;
            cart_id = cartId;

            InitializeComponent();
            baseOutlet = Properties.Settings.Default.BaseOutlet;
            MacAddressKasir = Properties.Settings.Default.MacAddressKasir;
            MacAddressKitchen = Properties.Settings.Default.MacAddressKitchen;
            MacAddressBar = Properties.Settings.Default.MacAddressBar;
            PinPrinterKasir = Properties.Settings.Default.PinPrinterKasir;
            PinPrinterKitchen = Properties.Settings.Default.PinPrinterKitchen;
            PinPrinterBar = Properties.Settings.Default.PinPrinterBar;
            BaseOutletName = Properties.Settings.Default.BaseOutletName;
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                int seat = 0;
                if (txtNama.Text.ToString() == "" || txtNama.Text == null)
                {
                    MessageBox.Show("Masukan nama pelanggan", "Gaspol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtSeat.Text.ToString() == "" || txtSeat.Text == null)
                {

                    seat = 0;
                }
                else
                {
                    seat = int.Parse(txtSeat.Text.ToString());
                }
              

                var json = new
                {
                    outlet_id = baseOutlet,
                    cart_id = int.Parse(cart_id),
                    customer_name = txtNama.Text.ToString(),
                    customer_seat = txtSeat.Text.ToString(),
                };
                string jsonString = JsonConvert.SerializeObject(json, Formatting.Indented);
                IApiService apiService = new ApiService();
                string response = await apiService.SaveBill(jsonString, "/transaction");
                if (response != null)
                {
                    GetStrukCustomerTransaction menuModel = JsonConvert.DeserializeObject<GetStrukCustomerTransaction>(response);
                    DataStrukCustomerTransaction data = menuModel.data;
                    List<CartDetailStrukCustomerTransaction> listCart = data.cart_details;
                    try
                    {
                        GetStrukCustomerTransaction datas = menuModel;
                        List<CartDetailStrukCustomerTransaction> cartDetails = datas.data.cart_details;

                        // Filter cart details by menu_type
                        List<CartDetailStrukCustomerTransaction> kitchenItems = cartDetails.Where(cd => cd.menu_type == "Makanan" || cd.menu_type == "Additional Makanan").ToList();
                        List<CartDetailStrukCustomerTransaction> barItems = cartDetails.Where(cd => cd.menu_type == "Minuman" || cd.menu_type == "Additional Minuman").ToList();
                        
                        PrintPurchaseReceipt(datas, cartDetails);

                        if (kitchenItems.Any())
                        {
                            PrintKitchenAndBarReceipts(datas, cartDetails, "Kitchen", MacAddressKitchen, PinPrinterKitchen);
                        }

                        if (barItems.Any())
                        {
                            PrintKitchenAndBarReceipts(datas, cartDetails, "Bar", MacAddressBar, PinPrinterBar);
                        }

                        DialogResult result = MessageBox.Show("Simpan bill sukses", "Gaspol", MessageBoxButtons.OK);
                        if (result == DialogResult.OK)
                        {
                            ReloadDataInBaseForm = true;

                        }
                        this.DialogResult = result;
                    }catch (Exception ex)
                    {
                        Console.WriteLine("Error printing: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal simpan bill " + ex.Message);
            }
        }

        // Struct Pembayaran
        private void PrintPurchaseReceipt(GetStrukCustomerTransaction datas, List<CartDetailStrukCustomerTransaction> cartDetails)
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
                string nomorMeja = "Meja No." + datas.data.customer_seat;

                // Struct template
                string strukText = "\n" + kodeHeksadesimalBold + CenterText(BaseOutletName) + "\n";
                strukText += kodeHeksadesimalNormal;
                strukText += "--------------------------------\n";

                strukText += kodeHeksadesimalSizeBesar + CenterText("Checker") + "\n";
                strukText += kodeHeksadesimalNormal;
                strukText += "--------------------------------\n";
                strukText += CenterText(datas.data.receipt_number) + "\n";
                strukText += FormatSimpleLine(datas.data.customer_name, nomorMeja) + "\n";

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
                        if (cartDetail.discounted_price.HasValue && cartDetail.discounted_price != 0)
                            strukText += FormatDetailItemLine("Total Discount", cartDetail.discounted_price) + "\n";

                        // Add an empty line between items
                        strukText += "\n";
                    }
                }
                strukText += "--------------------------------\n";
                strukText += FormatSimpleLine("Subtotal", datas.data.subtotal) + "\n";
                if (!string.IsNullOrEmpty(datas.data.discount_code))
                    strukText += FormatSimpleLine("Discount Code", datas.data.discount_code) + "\n";
                if (datas.data.discounts_value.HasValue && datas.data.discounts_value != 0)
                    strukText += FormatSimpleLine("Discount Value", datas.data.discounts_value) + "\n";
                strukText += FormatSimpleLine("Total", datas.data.total) + "\n";
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

        // Struct Kitchen&Bar
        private void PrintKitchenAndBarReceipts(GetStrukCustomerTransaction datas, List<CartDetailStrukCustomerTransaction> cartDetails, string header, string macAddress, string pinPrinter)
        {
            BluetoothDeviceInfo printer = new BluetoothDeviceInfo(BluetoothAddress.Parse(macAddress));
            if (printer == null)
            {
                MessageBox.Show("Printer" + macAddress + "not found.", "Gaspol");
                return;
            }

            BluetoothClient client = new BluetoothClient();
            BluetoothEndPoint endpoint = new BluetoothEndPoint(printer.DeviceAddress, BluetoothService.SerialPort);

            using (BluetoothClient clientSocket = new BluetoothClient())
            {
                if (!BluetoothSecurity.PairRequest(printer.DeviceAddress, pinPrinter))
                {
                    MessageBox.Show("Pairing failed to " + macAddress, "Gaspol");
                    return;
                }
                clientSocket.Connect(endpoint);
                System.IO.Stream stream = clientSocket.GetStream();

                // Template
                string kodeHeksadesimalBold = "\x1B\x45\x01";
                string kodeHeksadesimalSizeBesar = "\x1D\x21\x01";
                string kodeHeksadesimalSpasiKarakter = "\x1B\x20\x02";
                string kodeHeksadesimalNormal = "\x1B\x45\x00" + "\x1D\x21\x00" + "\x1B\x20\x00";

                // Custom variable
                string nomorMeja = "Meja No." + datas.data.customer_seat;

                // Generate struk text
                string strukText = kodeHeksadesimalSizeBesar + CenterText(header) + "\n";
                strukText += kodeHeksadesimalNormal;
                strukText += "--------------------------------\n";
                strukText += CenterText(datas.data.receipt_number) + "\n";
                strukText += CenterText(datas.data.invoice_due_date) + "\n \n";
                strukText += FormatSimpleLine(datas.data.customer_name, nomorMeja) + "\n";

                var servingTypes = cartDetails.Select(cd => cd.serving_type_name).Distinct();

                foreach (var servingType in servingTypes)
                {
                    var itemsForServingType = cartDetails.Where(cd => cd.serving_type_name == servingType).ToList();

                    if (itemsForServingType.Count == 0)
                        continue;

                    strukText += "--------------------------------\n";
                    strukText += CenterText(servingType) + "\n";
                    strukText += "--------------------------------\n";

                    foreach (var cartDetail in itemsForServingType)
                    {
                        string qtyMenu = "x " + cartDetail.qty.ToString();
                        strukText += kodeHeksadesimalSizeBesar + kodeHeksadesimalBold + kodeHeksadesimalSpasiKarakter + FormatKitchenBarLine(qtyMenu, cartDetail.menu_name) + kodeHeksadesimalNormal + "\n";

                        if (!string.IsNullOrEmpty(cartDetail.varian))
                            strukText += FormatDetailItemLine("Varian", cartDetail.varian) + "\n";
                        if (!string.IsNullOrEmpty(cartDetail.note_item?.ToString()))
                            strukText += FormatDetailItemLine("Note", cartDetail.note_item) + "\n";

                        // Add an empty line between items
                        strukText += "\n";
                    }
                }
                strukText += "--------------------------------\n\n\n\n\n";

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
    }
}
