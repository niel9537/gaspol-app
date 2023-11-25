namespace KASIR.Komponen
{
    partial class refund
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
            panel12 = new Panel();
            cmbPayform = new ComboBox();
            panel13 = new Panel();
            panel7 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            panel8 = new Panel();
            label5 = new Label();
            panel9 = new Panel();
            panel3 = new Panel();
            lblCustomerName = new Label();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            panel6 = new Panel();
            txtNotes = new TextBox();
            label3 = new Label();
            btnSimpan = new Button();
            btnKeluar = new Button();
            panel1.SuspendLayout();
            panel12.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel12);
            panel1.Controls.Add(panel13);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(btnSimpan);
            panel1.Controls.Add(btnKeluar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 530);
            panel1.TabIndex = 0;
            // 
            // panel12
            // 
            panel12.BackColor = SystemColors.ControlLightLight;
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Controls.Add(cmbPayform);
            panel12.Location = new Point(8, 160);
            panel12.Name = "panel12";
            panel12.Size = new Size(584, 38);
            panel12.TabIndex = 17;
            // 
            // cmbPayform
            // 
            cmbPayform.BackColor = Color.White;
            cmbPayform.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPayform.FlatStyle = FlatStyle.Flat;
            cmbPayform.FormattingEnabled = true;
            cmbPayform.Location = new Point(4, 5);
            cmbPayform.Name = "cmbPayform";
            cmbPayform.Size = new Size(573, 23);
            cmbPayform.TabIndex = 0;
            // 
            // panel13
            // 
            panel13.AutoScroll = true;
            panel13.Location = new Point(8, 204);
            panel13.Name = "panel13";
            panel13.Size = new Size(584, 199);
            panel13.TabIndex = 16;
            panel13.Paint += panel13_Paint;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(radioButton2);
            panel7.Controls.Add(radioButton1);
            panel7.Controls.Add(panel8);
            panel7.Location = new Point(8, 118);
            panel7.Name = "panel7";
            panel7.Size = new Size(584, 36);
            panel7.TabIndex = 14;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.FlatStyle = FlatStyle.Popup;
            radioButton2.Location = new Point(509, 9);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(68, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Per Item";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.FlatStyle = FlatStyle.Popup;
            radioButton1.Location = new Point(439, 9);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(60, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Semua";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.Controls.Add(label5);
            panel8.Controls.Add(panel9);
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(430, 36);
            panel8.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 11);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 2;
            label5.Text = "Tipe Refund";
            // 
            // panel9
            // 
            panel9.Location = new Point(426, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(174, 36);
            panel9.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblCustomerName);
            panel3.Location = new Point(8, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(584, 36);
            panel3.TabIndex = 13;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(13, 10);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(94, 15);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Customer Name";
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
            button2.Size = new Size(88, 29);
            button2.TabIndex = 7;
            button2.Text = "Refund";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtNotes);
            panel6.Controls.Add(label3);
            panel6.Location = new Point(8, 409);
            panel6.Name = "panel6";
            panel6.Size = new Size(584, 100);
            panel6.TabIndex = 11;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(2, 25);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.PlaceholderText = "Alasan refund ...";
            txtNotes.Size = new Size(575, 72);
            txtNotes.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(2, 5);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 8;
            label3.Text = "ALASAN";
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
            // refund
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 530);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "refund";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "refund";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnKeluar;
        private Button btnSimpan;
        private Panel panel6;
        private TextBox txtNotes;
        private Label label3;
        private Panel panel3;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Panel panel7;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Panel panel8;
        private Label label5;
        private Panel panel9;
        private Panel panel13;
        private Label lblCustomerName;
        private Panel panel12;
        private ComboBox cmbPayform;
    }
}