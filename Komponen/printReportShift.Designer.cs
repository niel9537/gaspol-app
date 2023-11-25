namespace KASIR.Komponen
{
    partial class printReportShift
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
            label2 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            maskedTextBox1 = new MaskedTextBox();
            panel3 = new Panel();
            maskedTextBox = new MaskedTextBox();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            btnSimpan = new Button();
            btnKeluar = new Button();
            panel5 = new Panel();
            label1 = new Label();
            txtActualCash = new TextBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnSimpan);
            panel1.Controls.Add(btnKeluar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 530);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 155);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 16;
            label2.Text = "Selesai Shift";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(8, 77);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 15;
            label5.Text = "Mulai Shift";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(maskedTextBox1);
            panel4.Location = new Point(12, 183);
            panel4.Name = "panel4";
            panel4.Size = new Size(576, 36);
            panel4.TabIndex = 14;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BorderStyle = BorderStyle.None;
            maskedTextBox1.Location = new Point(7, 8);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(551, 16);
            maskedTextBox1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(maskedTextBox);
            panel3.Location = new Point(12, 104);
            panel3.Name = "panel3";
            panel3.Size = new Size(576, 36);
            panel3.TabIndex = 13;
            // 
            // maskedTextBox
            // 
            maskedTextBox.BorderStyle = BorderStyle.None;
            maskedTextBox.Location = new Point(6, 7);
            maskedTextBox.Mask = "00:00";
            maskedTextBox.Name = "maskedTextBox";
            maskedTextBox.Size = new Size(552, 16);
            maskedTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 70);
            panel2.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.SteelBlue;
            button1.Location = new Point(12, 21);
            button1.Name = "button1";
            button1.Size = new Size(88, 30);
            button1.TabIndex = 8;
            button1.Text = "Keluar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(448, 21);
            button2.Name = "button2";
            button2.Size = new Size(140, 30);
            button2.TabIndex = 7;
            button2.Text = "Cetak Laporan";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.SteelBlue;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(500, 12);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(88, 29);
            btnSimpan.TabIndex = 10;
            btnSimpan.Text = "Refund";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.WhiteSmoke;
            btnKeluar.FlatAppearance.BorderSize = 0;
            btnKeluar.FlatStyle = FlatStyle.Flat;
            btnKeluar.ForeColor = Color.SteelBlue;
            btnKeluar.Location = new Point(12, 12);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(88, 29);
            btnKeluar.TabIndex = 9;
            btnKeluar.Text = "Batal";
            btnKeluar.UseVisualStyleBackColor = false;
            btnKeluar.Click += btnKeluar_Click;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(txtActualCash);
            panel5.Location = new Point(12, 257);
            panel5.Name = "panel5";
            panel5.Size = new Size(576, 36);
            panel5.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 232);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 17;
            label1.Text = "Uang Kasir";
            // 
            // txtActualCash
            // 
            txtActualCash.BorderStyle = BorderStyle.None;
            txtActualCash.Location = new Point(7, 9);
            txtActualCash.Name = "txtActualCash";
            txtActualCash.PlaceholderText = "Masukan uang kasir ...";
            txtActualCash.Size = new Size(551, 16);
            txtActualCash.TabIndex = 0;
            // 
            // printReportShift
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 530);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "printReportShift";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "refund";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        private void txtSelesaiShift_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Allow only numbers and colon (:)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ':')
            {
                e.Handled = true;
            }

            // Automatically insert colon after the second digit for the hour
            if (char.IsDigit(e.KeyChar) && textBox.TextLength == 2 && !textBox.Text.Contains(':'))
            {
                textBox.Text += ":";
                textBox.SelectionStart = textBox.Text.Length; // Place cursor at the end
            }

            // Prevent typing after 5 characters (HH:mm format)
            if (textBox.Text.Length >= 5 && e.KeyChar != '\b') // '\b' is Backspace key
            {
                e.Handled = true;
            }
        }


        private void txtMulaiShift_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Allow only numbers and colon (:)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ':')
            {
                e.Handled = true;
            }

            // Allow a colon only if no colon exists, and the length is 2 or 3 (for HH:mm format)
            if (e.KeyChar == ':' && (textBox.Text.IndexOf(':') > -1 || textBox.Text.Length >= 3))
            {
                e.Handled = true;
            }
        }


        #endregion

        private Panel panel1;
        private Button btnKeluar;
        private Button btnSimpan;
        private Panel panel3;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Panel panel4;
        private Label label2;
        private Label label5;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox;
        private Label label1;
        private Panel panel5;
        private TextBox txtActualCash;
    }
}