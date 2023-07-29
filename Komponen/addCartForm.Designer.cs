namespace KASIR.komponen
{
    partial class addCartForm
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
            panel1 = new Panel();
            btnKeluar = new Button();
            btnSimpan = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            panel4 = new Panel();
            btnTambah = new Button();
            btnKurang = new Button();
            panel3 = new Panel();
            txtKuantitas = new TextBox();
            label1 = new Label();
            panel5 = new Panel();
            button1 = new Button();
            btnDinein = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(btnKeluar);
            panel1.Controls.Add(btnSimpan);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 70);
            panel1.TabIndex = 1;
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
            btnKeluar.Click += btnKeluar_Click;
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
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Location = new Point(0, 70);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(600, 328);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(596, 74);
            panel2.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnTambah);
            panel4.Controls.Add(btnKurang);
            panel4.Location = new Point(296, 23);
            panel4.Name = "panel4";
            panel4.Size = new Size(288, 36);
            panel4.TabIndex = 3;
            // 
            // btnTambah
            // 
            btnTambah.FlatStyle = FlatStyle.Popup;
            btnTambah.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnTambah.Location = new Point(143, 0);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(145, 36);
            btnTambah.TabIndex = 1;
            btnTambah.Text = "+";
            btnTambah.UseVisualStyleBackColor = true;
            // 
            // btnKurang
            // 
            btnKurang.FlatStyle = FlatStyle.Popup;
            btnKurang.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnKurang.Location = new Point(0, 0);
            btnKurang.Name = "btnKurang";
            btnKurang.Size = new Size(144, 36);
            btnKurang.TabIndex = 0;
            btnKurang.Text = "-";
            btnKurang.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtKuantitas);
            panel3.Location = new Point(8, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(280, 36);
            panel3.TabIndex = 2;
            // 
            // txtKuantitas
            // 
            txtKuantitas.BorderStyle = BorderStyle.None;
            txtKuantitas.Location = new Point(18, 9);
            txtKuantitas.Name = "txtKuantitas";
            txtKuantitas.PlaceholderText = "Masukan kuantitas ...";
            txtKuantitas.Size = new Size(246, 16);
            txtKuantitas.TabIndex = 0;
            txtKuantitas.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(5, 5);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 1;
            label1.Text = "KUANTITAS";
            label1.Click += label1_Click_2;
            // 
            // panel5
            // 
            panel5.Controls.Add(button1);
            panel5.Controls.Add(btnDinein);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(3, 83);
            panel5.Name = "panel5";
            panel5.Size = new Size(596, 120);
            panel5.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(296, 23);
            button1.Name = "button1";
            button1.Size = new Size(288, 36);
            button1.TabIndex = 3;
            button1.Text = "Gofood";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnDinein
            // 
            btnDinein.BackColor = Color.SteelBlue;
            btnDinein.FlatStyle = FlatStyle.Flat;
            btnDinein.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDinein.ForeColor = Color.White;
            btnDinein.Location = new Point(8, 23);
            btnDinein.Name = "btnDinein";
            btnDinein.Size = new Size(280, 36);
            btnDinein.TabIndex = 2;
            btnDinein.Text = "Dine In";
            btnDinein.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(4, 5);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 1;
            label2.Text = "TIPE PENJUALAN";
            // 
            // addCartForm
            // 
            ClientSize = new Size(600, 400);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addCartForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Button btnKeluar;
        private Button btnSimpan;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtKuantitas;
        private Label label1;
        private Panel panel2;
        private Panel panel4;
        private Button btnTambah;
        private Button btnKurang;
        private Panel panel3;
        private Panel panel5;
        private Label label2;
        private Button button1;
        private Button btnDinein;
    }
}