namespace KASIR.komponen
{
    partial class masterPos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel3 = new Panel();
            listBill = new Button();
            panel6 = new Panel();
            lblDiskon1 = new Label();
            btnGet = new Button();
            label1 = new Label();
            panel9 = new Panel();
            cmbDiskon = new ComboBox();
            lblTotal1 = new Label();
            lblSubTotal1 = new Label();
            lblTotal = new Label();
            lblSubTotal = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button5 = new Button();
            panel4 = new Panel();
            label3 = new Label();
            textBox2 = new TextBox();
            button4 = new Button();
            panel7 = new Panel();
            cmbFilter = new ComboBox();
            panel5 = new Panel();
            txtCariMenu = new TextBox();
            panel2 = new Panel();
            dataGridView3 = new FlowLayoutPanel();
            panel8 = new Panel();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(listBill);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(panel4);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(695, 9);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5);
            panel3.Size = new Size(410, 657);
            panel3.TabIndex = 8;
            panel3.Paint += panel3_Paint;
            // 
            // listBill
            // 
            listBill.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            listBill.BackColor = Color.White;
            listBill.FlatAppearance.BorderSize = 0;
            listBill.FlatStyle = FlatStyle.Flat;
            listBill.ForeColor = Color.SteelBlue;
            listBill.Location = new Point(4, 6);
            listBill.Name = "listBill";
            listBill.Size = new Size(200, 46);
            listBill.TabIndex = 16;
            listBill.Text = "List Bill";
            listBill.UseVisualStyleBackColor = false;
            listBill.Click += listBill_Click;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel6.BackColor = Color.White;
            panel6.Controls.Add(lblDiskon1);
            panel6.Controls.Add(btnGet);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(panel9);
            panel6.Controls.Add(lblTotal1);
            panel6.Controls.Add(lblSubTotal1);
            panel6.Controls.Add(lblTotal);
            panel6.Controls.Add(lblSubTotal);
            panel6.Location = new Point(2, 412);
            panel6.Name = "panel6";
            panel6.Size = new Size(400, 135);
            panel6.TabIndex = 15;
            // 
            // lblDiskon1
            // 
            lblDiskon1.AutoSize = true;
            lblDiskon1.BackColor = Color.White;
            lblDiskon1.ForeColor = Color.Black;
            lblDiskon1.Location = new Point(272, 66);
            lblDiskon1.Name = "lblDiskon1";
            lblDiskon1.Size = new Size(51, 15);
            lblDiskon1.TabIndex = 9;
            lblDiskon1.Text = "- Diskon";
            // 
            // btnGet
            // 
            btnGet.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGet.BackColor = Color.White;
            btnGet.FlatAppearance.BorderSize = 0;
            btnGet.FlatStyle = FlatStyle.Flat;
            btnGet.ForeColor = Color.SteelBlue;
            btnGet.Location = new Point(327, 15);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(70, 41);
            btnGet.TabIndex = 8;
            btnGet.Text = "Gunakan";
            btnGet.UseVisualStyleBackColor = false;
            btnGet.Click += btnGet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 63);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 5;
            label1.Text = "Diskon :";
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(cmbDiskon);
            panel9.Location = new Point(6, 15);
            panel9.Name = "panel9";
            panel9.Size = new Size(319, 41);
            panel9.TabIndex = 4;
            // 
            // cmbDiskon
            // 
            cmbDiskon.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDiskon.FlatStyle = FlatStyle.Flat;
            cmbDiskon.FormattingEnabled = true;
            cmbDiskon.Location = new Point(9, 9);
            cmbDiskon.Name = "cmbDiskon";
            cmbDiskon.Size = new Size(305, 23);
            cmbDiskon.TabIndex = 1;
            cmbDiskon.SelectedIndexChanged += cmbDiskon_SelectedIndexChanged;
            // 
            // lblTotal1
            // 
            lblTotal1.AutoSize = true;
            lblTotal1.BackColor = Color.White;
            lblTotal1.ForeColor = Color.Black;
            lblTotal1.Location = new Point(273, 112);
            lblTotal1.Name = "lblTotal1";
            lblTotal1.Size = new Size(32, 15);
            lblTotal1.TabIndex = 3;
            lblTotal1.Text = "Total";
            lblTotal1.Click += lblTotal1_Click;
            // 
            // lblSubTotal1
            // 
            lblSubTotal1.AutoSize = true;
            lblSubTotal1.BackColor = Color.White;
            lblSubTotal1.ForeColor = Color.Black;
            lblSubTotal1.Location = new Point(273, 87);
            lblSubTotal1.Name = "lblSubTotal1";
            lblSubTotal1.Size = new Size(52, 15);
            lblSubTotal1.TabIndex = 2;
            lblSubTotal1.Text = "SubTotal";
            lblSubTotal1.Click += lblSubTotal1_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.White;
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(3, 112);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(41, 15);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total : ";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.BackColor = Color.White;
            lblSubTotal.ForeColor = Color.Black;
            lblSubTotal.Location = new Point(3, 86);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(58, 15);
            lblSubTotal.TabIndex = 0;
            lblSubTotal.Text = "SubTotal :";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.Transparent;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = Color.Gainsboro;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.ImeMode = ImeMode.NoControl;
            dataGridView1.Location = new Point(2, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Gainsboro;
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(400, 354);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellPainting += DataGridView1_CellPainting;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 449);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 200);
            panel1.TabIndex = 8;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.SteelBlue;
            button3.Location = new Point(199, 104);
            button3.Name = "button3";
            button3.Size = new Size(204, 46);
            button3.TabIndex = 7;
            button3.Text = "List Diskon";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.SteelBlue;
            button2.Location = new Point(2, 104);
            button2.Name = "button2";
            button2.Size = new Size(200, 46);
            button2.TabIndex = 6;
            button2.Text = "Simpan Bill";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 151);
            button1.Name = "button1";
            button1.Size = new Size(400, 46);
            button1.TabIndex = 5;
            button1.Text = "Bayar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 192, 192);
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.Red;
            button5.Location = new Point(204, 6);
            button5.Name = "button5";
            button5.Size = new Size(199, 46);
            button5.TabIndex = 6;
            button5.Text = "Hapus Pesanan";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_ClickAsync;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(button4);
            panel4.Location = new Point(13, 975);
            panel4.Name = "panel4";
            panel4.Size = new Size(594, 128);
            panel4.TabIndex = 0;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(4, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 7;
            label3.Text = "Total";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.AutoCompleteSource = AutoCompleteSource.FileSystem;
            textBox2.BackColor = Color.WhiteSmoke;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.SteelBlue;
            textBox2.Location = new Point(419, 57);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Rp.0";
            textBox2.RightToLeft = RightToLeft.No;
            textBox2.Size = new Size(169, 30);
            textBox2.TabIndex = 6;
            // 
            // button4
            // 
            button4.BackColor = Color.SteelBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(3, 79);
            button4.Name = "button4";
            button4.Size = new Size(400, 46);
            button4.TabIndex = 5;
            button4.Text = "Bayar";
            button4.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(cmbFilter);
            panel7.Location = new Point(5, 54);
            panel7.Name = "panel7";
            panel7.Size = new Size(465, 41);
            panel7.TabIndex = 16;
            // 
            // cmbFilter
            // 
            cmbFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.FlatStyle = FlatStyle.Flat;
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Location = new Point(4, 5);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(446, 23);
            cmbFilter.TabIndex = 0;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(txtCariMenu);
            panel5.Location = new Point(5, 7);
            panel5.Name = "panel5";
            panel5.Size = new Size(414, 41);
            panel5.TabIndex = 14;
            // 
            // txtCariMenu
            // 
            txtCariMenu.BorderStyle = BorderStyle.None;
            txtCariMenu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCariMenu.Location = new Point(9, 11);
            txtCariMenu.Name = "txtCariMenu";
            txtCariMenu.PlaceholderText = "Masukan nama menu";
            txtCariMenu.Size = new Size(402, 16);
            txtCariMenu.TabIndex = 0;
            txtCariMenu.TextChanged += txtCariMenu_TextChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView3);
            panel2.Controls.Add(panel8);
            panel2.Location = new Point(6, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(683, 660);
            panel2.TabIndex = 9;
            // 
            // dataGridView3
            // 
            dataGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView3.Location = new Point(0, 115);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(683, 545);
            dataGridView3.TabIndex = 18;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel8.Controls.Add(panel5);
            panel8.Controls.Add(panel7);
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(683, 109);
            panel8.TabIndex = 17;
            // 
            // masterPos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1120, 681);
            Controls.Add(panel2);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "masterPos";
            Text = "menu";
            Load += masterPos_Load;
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel7.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }


        #endregion

        private Panel panel3;
        private Button button5;
        private Panel panel4;
        private Label label3;
        private TextBox textBox2;
        private Button button4;
        private Panel panel1;
        private Button button1;
        private Panel panel5;
        private TextBox txtCariMenu;
        private DataGridView dataGridView1;
        private Button button2;
        private Panel panel6;
        private Button button3;
        private Label lblSubTotal;
        private Label lblTotal;
        private Label lblTotal1;
        private Label lblSubTotal1;
        private Panel panel7;
        private ComboBox cmbFilter;
        private Panel panel2;
        private Panel panel8;
        private Button btnGet;
        private Panel panel9;
        private ComboBox cmbDiskon;
        private Label label1;
        private Button button6;
        private Label lblDiskon1;
        private Button listBill;
        private FlowLayoutPanel dataGridView3;
    }
}