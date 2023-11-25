namespace KASIR.Komponen
{
    partial class notifikasiPengeluaran
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
            panel5 = new Panel();
            txtNominal = new TextBox();
            label2 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            txtNotes = new TextBox();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            btnSimpan = new Button();
            btnKeluar = new Button();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnSimpan);
            panel1.Controls.Add(btnKeluar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 530);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(txtNominal);
            panel5.Location = new Point(12, 105);
            panel5.Name = "panel5";
            panel5.Size = new Size(576, 36);
            panel5.TabIndex = 17;
            // 
            // txtNominal
            // 
            txtNominal.BorderStyle = BorderStyle.None;
            txtNominal.Location = new Point(11, 9);
            txtNominal.Name = "txtNominal";
            txtNominal.PlaceholderText = "Rp .";
            txtNominal.Size = new Size(551, 16);
            txtNominal.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(9, 156);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 16;
            label2.Text = "Deskripsi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(8, 77);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 15;
            label5.Text = "Nominal";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txtNotes);
            panel4.Location = new Point(12, 183);
            panel4.Name = "panel4";
            panel4.Size = new Size(576, 187);
            panel4.TabIndex = 14;
            // 
            // txtNotes
            // 
            txtNotes.BorderStyle = BorderStyle.None;
            txtNotes.Location = new Point(8, 7);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.PlaceholderText = "Alasan refund ...";
            txtNotes.Size = new Size(559, 168);
            txtNotes.TabIndex = 2;
            txtNotes.TextChanged += txtNotes_TextChanged;
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
            button2.Location = new Point(500, 21);
            button2.Name = "button2";
            button2.Size = new Size(88, 30);
            button2.TabIndex = 7;
            button2.Text = "Simpan";
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
            // notifikasiPengeluaran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 530);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "notifikasiPengeluaran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "refund";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
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
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Panel panel4;
        private Label label2;
        private Label label5;
        private Panel panel5;
        private TextBox txtNominal;
        private TextBox txtNotes;
    }
}