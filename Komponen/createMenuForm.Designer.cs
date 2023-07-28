namespace KASIR.komponen
{
    partial class createMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createMenuForm));
            panel1 = new Panel();
            label1 = new Label();
            btnKeluar = new Button();
            btnSimpan = new Button();
            panel2 = new Panel();
            txtHarga = new TextBox();
            btnTambah = new Button();
            cmbTipe = new ComboBox();
            txtNama = new TextBox();
            button5 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowVarian = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnKeluar);
            panel1.Controls.Add(btnSimpan);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(598, 70);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(212, 15);
            label1.Name = "label1";
            label1.Size = new Size(178, 35);
            label1.TabIndex = 9;
            label1.Text = "Tambah Menu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.WhiteSmoke;
            btnKeluar.FlatAppearance.BorderSize = 0;
            btnKeluar.FlatStyle = FlatStyle.Flat;
            btnKeluar.ForeColor = Color.SteelBlue;
            btnKeluar.Location = new Point(12, 21);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(88, 30);
            btnKeluar.TabIndex = 8;
            btnKeluar.Text = "Keluar";
            btnKeluar.UseVisualStyleBackColor = false;
            btnKeluar.Click += button1_Click_1;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.SteelBlue;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(500, 21);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(88, 29);
            btnSimpan.TabIndex = 7;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += button4_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtHarga);
            panel2.Controls.Add(btnTambah);
            panel2.Controls.Add(cmbTipe);
            panel2.Controls.Add(txtNama);
            panel2.Controls.Add(button5);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(585, 151);
            panel2.TabIndex = 19;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(114, 80);
            txtHarga.Name = "txtHarga";
            txtHarga.PlaceholderText = "Harga Menu";
            txtHarga.Size = new Size(471, 23);
            txtHarga.TabIndex = 20;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.SteelBlue;
            btnTambah.FlatAppearance.BorderSize = 0;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(9, 119);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(576, 29);
            btnTambah.TabIndex = 10;
            btnTambah.Text = "Tambah Varian";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click_1;
            // 
            // cmbTipe
            // 
            cmbTipe.FormattingEnabled = true;
            cmbTipe.Location = new Point(114, 51);
            cmbTipe.Name = "cmbTipe";
            cmbTipe.Size = new Size(471, 23);
            cmbTipe.TabIndex = 19;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(114, 22);
            txtNama.Name = "txtNama";
            txtNama.PlaceholderText = "Nama Menu";
            txtNama.Size = new Size(471, 23);
            txtNama.TabIndex = 18;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.BackColor = Color.Transparent;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.Black;
            button5.ImageAlign = ContentAlignment.TopLeft;
            button5.Location = new Point(9, -16);
            button5.Name = "button5";
            button5.Size = new Size(99, 164);
            button5.TabIndex = 17;
            button5.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.WhiteSmoke;
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(flowVarian);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(1, 71);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(598, 328);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // flowVarian
            // 
            flowVarian.FlowDirection = FlowDirection.TopDown;
            flowVarian.Location = new Point(3, 160);
            flowVarian.Name = "flowVarian";
            flowVarian.Padding = new Padding(5, 0, 0, 0);
            flowVarian.Size = new Size(585, 165);
            flowVarian.TabIndex = 20;
            flowVarian.Paint += flowVarian_Paint;
            // 
            // createMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(600, 400);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "createMenuForm";
            Padding = new Padding(1);
            StartPosition = FormStartPosition.CenterParent;
            Text = "create1";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Button btnSimpan;
        private Button btnKeluar;
        private Label label1;
        private Panel panel2;
        private TextBox txtNama;
        private Button button5;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox cmbTipe;
        private Button btnTambah;
        private TextBox txtHarga;
        private FlowLayoutPanel flowVarian;
    }
}