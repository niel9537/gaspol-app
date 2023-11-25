namespace KASIR.Komponen
{
    partial class inputPin
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
            panel2 = new Panel();
            panel3 = new Panel();
            txtPin = new TextBox();
            btnKonfirmasi = new Button();
            btnKeluar = new Button();
            label1 = new Label();
            panel1 = new Panel();
            btnCetakStruk = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCetakStruk);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnKonfirmasi);
            panel2.Controls.Add(btnKeluar);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 212);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtPin);
            panel3.Location = new Point(38, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(521, 36);
            panel3.TabIndex = 16;
            // 
            // txtPin
            // 
            txtPin.BorderStyle = BorderStyle.None;
            txtPin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPin.Location = new Point(138, 8);
            txtPin.MaxLength = 5;
            txtPin.Name = "txtPin";
            txtPin.PlaceholderText = "*****";
            txtPin.Size = new Size(246, 22);
            txtPin.TabIndex = 0;
            txtPin.TextAlign = HorizontalAlignment.Center;
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.BackColor = Color.SteelBlue;
            btnKonfirmasi.FlatAppearance.BorderSize = 0;
            btnKonfirmasi.FlatStyle = FlatStyle.Flat;
            btnKonfirmasi.ForeColor = Color.White;
            btnKonfirmasi.Location = new Point(38, 106);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(521, 32);
            btnKonfirmasi.TabIndex = 15;
            btnKonfirmasi.Text = "Konfirmasi";
            btnKonfirmasi.UseVisualStyleBackColor = false;
            btnKonfirmasi.Click += btnKonfirmasi_Click;
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.WhiteSmoke;
            btnKeluar.FlatAppearance.BorderSize = 0;
            btnKeluar.FlatStyle = FlatStyle.Flat;
            btnKeluar.ForeColor = Color.SteelBlue;
            btnKeluar.Location = new Point(38, 12);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(88, 30);
            btnKeluar.TabIndex = 14;
            btnKeluar.Text = "Kembali";
            btnKeluar.UseVisualStyleBackColor = false;
            btnKeluar.Click += btnKeluar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(244, 20);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "Masukkan Kode Pin";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 530);
            panel1.TabIndex = 1;
            // 
            // btnCetakStruk
            // 
            btnCetakStruk.BackColor = Color.SteelBlue;
            btnCetakStruk.FlatAppearance.BorderSize = 0;
            btnCetakStruk.FlatStyle = FlatStyle.Flat;
            btnCetakStruk.ForeColor = Color.White;
            btnCetakStruk.Location = new Point(454, 12);
            btnCetakStruk.Name = "btnCetakStruk";
            btnCetakStruk.Size = new Size(105, 30);
            btnCetakStruk.TabIndex = 17;
            btnCetakStruk.Text = "Cetak Struk";
            btnCetakStruk.UseVisualStyleBackColor = false;
            btnCetakStruk.Click += btnCetakStruk_Click;
            // 
            // inputPin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 530);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "inputPin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "inputPin";
            TopMost = true;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnKeluar;
        private Label label1;
        private Panel panel1;
        private Button btnKonfirmasi;
        private Panel panel3;
        private TextBox txtPin;
        private Button btnCetakStruk;
    }
}