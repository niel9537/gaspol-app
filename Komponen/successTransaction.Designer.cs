namespace KASIR.Komponen
{
    partial class successTransaction
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnReportShift = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            btnAddMenu = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btnNotifikasiPengeluaran = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.SteelBlue;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.SteelBlue;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle7.SelectionForeColor = Color.Transparent;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.ImeMode = ImeMode.NoControl;
            dataGridView1.Location = new Point(13, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gainsboro;
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(888, 466);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(912, 510);
            panel2.TabIndex = 7;
            // 
            // btnReportShift
            // 
            btnReportShift.BackColor = Color.WhiteSmoke;
            btnReportShift.FlatAppearance.BorderSize = 0;
            btnReportShift.FlatStyle = FlatStyle.Flat;
            btnReportShift.ForeColor = Color.SteelBlue;
            btnReportShift.Location = new Point(13, 24);
            btnReportShift.Name = "btnReportShift";
            btnReportShift.Size = new Size(127, 29);
            btnReportShift.TabIndex = 13;
            btnReportShift.Text = "Laporan Shift";
            btnReportShift.UseVisualStyleBackColor = false;
            btnReportShift.Click += btnReportShift_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.DarkGray;
            label1.Location = new Point(13, 1);
            label1.Name = "label1";
            label1.Size = new Size(1573, 1);
            label1.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnNotifikasiPengeluaran);
            panel1.Controls.Add(btnReportShift);
            panel1.Controls.Add(btnAddMenu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(912, 70);
            panel1.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(13, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(888, 29);
            panel3.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.search_20px;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.InitialImage = Properties.Resources.search_20px;
            pictureBox1.Location = new Point(844, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 28);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(17, 5);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Cari transaksi ...";
            textBox1.Size = new Size(857, 18);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnAddMenu
            // 
            btnAddMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddMenu.AutoSize = true;
            btnAddMenu.BackColor = Color.SteelBlue;
            btnAddMenu.FlatAppearance.BorderSize = 0;
            btnAddMenu.FlatStyle = FlatStyle.Flat;
            btnAddMenu.ForeColor = Color.White;
            btnAddMenu.Location = new Point(1447, 23);
            btnAddMenu.Name = "btnAddMenu";
            btnAddMenu.Size = new Size(148, 29);
            btnAddMenu.TabIndex = 11;
            btnAddMenu.Text = "Tambah Menu";
            btnAddMenu.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2000;
            // 
            // btnNotifikasiPengeluaran
            // 
            btnNotifikasiPengeluaran.BackColor = Color.WhiteSmoke;
            btnNotifikasiPengeluaran.FlatAppearance.BorderSize = 0;
            btnNotifikasiPengeluaran.FlatStyle = FlatStyle.Flat;
            btnNotifikasiPengeluaran.ForeColor = Color.SteelBlue;
            btnNotifikasiPengeluaran.Location = new Point(146, 24);
            btnNotifikasiPengeluaran.Name = "btnNotifikasiPengeluaran";
            btnNotifikasiPengeluaran.Size = new Size(127, 29);
            btnNotifikasiPengeluaran.TabIndex = 14;
            btnNotifikasiPengeluaran.Text = "Pengeluaran";
            btnNotifikasiPengeluaran.UseVisualStyleBackColor = false;
            btnNotifikasiPengeluaran.Click += btnNotifikasiPengeluaran_Click;
            // 
            // successTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "successTransaction";
            Size = new Size(912, 580);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button btnAddMenu;
        private System.Windows.Forms.Timer timer1;
        private Button btnReportShift;
        private Button btnNotifikasiPengeluaran;
    }
}
