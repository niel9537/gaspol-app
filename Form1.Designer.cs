namespace KASIR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button6 = new Button();
            panel3 = new Panel();
            panel1 = new Panel();
            panel4 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(100, 580);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(6, 161);
            button1.Name = "button1";
            button1.Size = new Size(92, 66);
            button1.TabIndex = 16;
            button1.Text = "Riwayat";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(8, 305);
            button2.Name = "button2";
            button2.Size = new Size(92, 66);
            button2.TabIndex = 14;
            button2.Text = "Produk";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button6
            // 
            button6.BackColor = Color.SteelBlue;
            button6.BackgroundImageLayout = ImageLayout.None;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(6, 89);
            button6.Name = "button6";
            button6.Size = new Size(92, 66);
            button6.TabIndex = 11;
            button6.Text = "Menu";
            button6.TextImageRelation = TextImageRelation.ImageAboveText;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(0, 89);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 66);
            panel3.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(100, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(912, 580);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.MidnightBlue;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(912, 8);
            panel4.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1012, 580);
            Controls.Add(panel1);
            Controls.Add(panel2);
            ForeColor = Color.Maroon;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kasir";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button button6;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Button button2;
        private Button button1;
    }
}