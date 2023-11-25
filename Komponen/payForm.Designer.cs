namespace KASIR.komponen
{
    partial class payForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel9 = new Panel();
            panel10 = new Panel();
            txtSeat = new TextBox();
            label5 = new Label();
            panel11 = new Panel();
            txtNama = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            btnSetPrice3 = new Button();
            btnSetPrice2 = new Button();
            btnSetPrice1 = new Button();
            txtJumlahPembayaran = new Label();
            panel5 = new Panel();
            txtCash = new TextBox();
            label1 = new Label();
            panel6 = new Panel();
            panel12 = new Panel();
            cmbPayform = new ComboBox();
            label6 = new Label();
            panel2 = new Panel();
            btnKeluar = new Button();
            btnSimpan = new Button();
            panel7 = new Panel();
            btnTunai = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel12.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.SteelBlue;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 530);
            panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(panel9);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Location = new Point(0, 70);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(598, 455);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel10);
            panel9.Controls.Add(label5);
            panel9.Controls.Add(panel11);
            panel9.Controls.Add(label4);
            panel9.Location = new Point(3, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(597, 74);
            panel9.TabIndex = 4;
            // 
            // panel10
            // 
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(txtSeat);
            panel10.Location = new Point(313, 22);
            panel10.Name = "panel10";
            panel10.Size = new Size(271, 36);
            panel10.TabIndex = 4;
            // 
            // txtSeat
            // 
            txtSeat.BorderStyle = BorderStyle.None;
            txtSeat.Location = new Point(11, 9);
            txtSeat.Name = "txtSeat";
            txtSeat.PlaceholderText = "Masukan Nomor Seat ...";
            txtSeat.Size = new Size(246, 16);
            txtSeat.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(310, 4);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 3;
            label5.Text = "SEAT";
            // 
            // panel11
            // 
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(txtNama);
            panel11.Location = new Point(8, 23);
            panel11.Name = "panel11";
            panel11.Size = new Size(270, 36);
            panel11.TabIndex = 2;
            // 
            // txtNama
            // 
            txtNama.BorderStyle = BorderStyle.None;
            txtNama.Location = new Point(11, 9);
            txtNama.Name = "txtNama";
            txtNama.PlaceholderText = "Masukan Nama ...";
            txtNama.Size = new Size(246, 16);
            txtNama.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(5, 5);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 1;
            label4.Text = "NAMA";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSetPrice3);
            panel3.Controls.Add(btnSetPrice2);
            panel3.Controls.Add(btnSetPrice1);
            panel3.Controls.Add(txtJumlahPembayaran);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(3, 83);
            panel3.Name = "panel3";
            panel3.Size = new Size(597, 176);
            panel3.TabIndex = 2;
            // 
            // btnSetPrice3
            // 
            btnSetPrice3.FlatStyle = FlatStyle.Flat;
            btnSetPrice3.ForeColor = Color.Black;
            btnSetPrice3.Location = new Point(411, 70);
            btnSetPrice3.Name = "btnSetPrice3";
            btnSetPrice3.Size = new Size(174, 36);
            btnSetPrice3.TabIndex = 8;
            btnSetPrice3.Text = "Rp. 1000000";
            btnSetPrice3.UseVisualStyleBackColor = true;
            btnSetPrice3.Click += btnSetPrice3_Click;
            // 
            // btnSetPrice2
            // 
            btnSetPrice2.FlatStyle = FlatStyle.Flat;
            btnSetPrice2.ForeColor = Color.Black;
            btnSetPrice2.Location = new Point(211, 70);
            btnSetPrice2.Name = "btnSetPrice2";
            btnSetPrice2.Size = new Size(174, 36);
            btnSetPrice2.TabIndex = 7;
            btnSetPrice2.Text = "Rp. 500000";
            btnSetPrice2.UseVisualStyleBackColor = true;
            btnSetPrice2.Click += btnSetPrice2_Click_1;
            // 
            // btnSetPrice1
            // 
            btnSetPrice1.FlatStyle = FlatStyle.Flat;
            btnSetPrice1.ForeColor = Color.Black;
            btnSetPrice1.Location = new Point(9, 71);
            btnSetPrice1.Name = "btnSetPrice1";
            btnSetPrice1.Size = new Size(174, 36);
            btnSetPrice1.TabIndex = 6;
            btnSetPrice1.Text = "Rp. 30000";
            btnSetPrice1.UseVisualStyleBackColor = true;
            btnSetPrice1.Click += btnSetPrice1_Click;
            // 
            // txtJumlahPembayaran
            // 
            txtJumlahPembayaran.AutoSize = true;
            txtJumlahPembayaran.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtJumlahPembayaran.ForeColor = Color.Black;
            txtJumlahPembayaran.Location = new Point(5, 30);
            txtJumlahPembayaran.Name = "txtJumlahPembayaran";
            txtJumlahPembayaran.Size = new Size(0, 15);
            txtJumlahPembayaran.TabIndex = 3;
            txtJumlahPembayaran.Click += label3_Click;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(txtCash);
            panel5.Location = new Point(9, 123);
            panel5.Name = "panel5";
            panel5.Size = new Size(576, 36);
            panel5.TabIndex = 2;
            panel5.Paint += panel5_Paint;
            // 
            // txtCash
            // 
            txtCash.BorderStyle = BorderStyle.None;
            txtCash.Location = new Point(11, 9);
            txtCash.Name = "txtCash";
            txtCash.PlaceholderText = "Rp .";
            txtCash.Size = new Size(551, 16);
            txtCash.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(5, 5);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "CASH";
            // 
            // panel6
            // 
            panel6.Controls.Add(panel12);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(3, 265);
            panel6.Name = "panel6";
            panel6.Size = new Size(597, 74);
            panel6.TabIndex = 11;
            // 
            // panel12
            // 
            panel12.BackColor = SystemColors.ControlLightLight;
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Controls.Add(cmbPayform);
            panel12.Location = new Point(8, 24);
            panel12.Name = "panel12";
            panel12.Size = new Size(576, 38);
            panel12.TabIndex = 5;
            // 
            // cmbPayform
            // 
            cmbPayform.BackColor = Color.White;
            cmbPayform.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPayform.FlatStyle = FlatStyle.Flat;
            cmbPayform.FormattingEnabled = true;
            cmbPayform.Location = new Point(3, 4);
            cmbPayform.Name = "cmbPayform";
            cmbPayform.Size = new Size(568, 23);
            cmbPayform.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(4, 6);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 4;
            label6.Text = "TIPE PEMBAYARAN";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(btnKeluar);
            panel2.Controls.Add(btnSimpan);
            panel2.Controls.Add(panel7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(598, 70);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
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
            btnSimpan.Size = new Size(87, 29);
            btnSimpan.TabIndex = 7;
            btnSimpan.Text = "Konfirmasi";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // panel7
            // 
            panel7.Location = new Point(3, 70);
            panel7.Name = "panel7";
            panel7.Size = new Size(585, 10);
            panel7.TabIndex = 6;
            // 
            // btnTunai
            // 
            btnTunai.BackColor = SystemColors.ControlDark;
            btnTunai.FlatStyle = FlatStyle.Flat;
            btnTunai.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTunai.ForeColor = Color.White;
            btnTunai.Location = new Point(8, 23);
            btnTunai.Name = "btnTunai";
            btnTunai.Size = new Size(270, 36);
            btnTunai.TabIndex = 2;
            btnTunai.Text = "Tunai";
            btnTunai.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(4, 5);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 1;
            label2.Text = "TIPE PEMBAYARAN";
            // 
            // payForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 530);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "payForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "create1";
            TopMost = true;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel12.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Button btnKeluar;
        private Button btnSimpan;
        private Panel panel7;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel9;
        private Panel panel10;
        private TextBox txtSeat;
        private Label label5;
        private Panel panel11;
        private TextBox txtNama;
        private Label label4;
        private Panel panel3;
        private Button btnTambah;
        private Button btnKurang;
        private Panel panel5;
        private TextBox txtKuantitas;
        private Label label1;
        private Button btnTunai;
        private Label label2;
        private TextBox txtNotes;
        private TextBox txtCash;
        private Panel panel6;
        private Panel panel12;
        private ComboBox cmbPayform;
        private Label label6;
        private Label txtJumlahPembayaran;
        private Button btnSetPrice1;
        private Button btnSetPrice2;
        private Button btnSetPrice3;
    }
}