using KASIR.komponen;
using KASIR.Komponen;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace KASIR
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Height = 800;
            this.Width = 1200;
            panel3.Height = button6.Height;
            panel3.Top = button6.Top;
            masterPos m = new masterPos();
            m.TopLevel = false;
            m.Dock = DockStyle.Fill;
            panel1.Controls.Add(m);
            m.BringToFront();
            m.Show();
            //int newHeight = Screen.PrimaryScreen.WorkingArea.Height - 400;
            //Height = newHeight;
            //this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Height += 100;
            button2.Enabled = false;
            button2.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Height = button6.Height;
            panel3.Top = button6.Top;
            masterPos m = new masterPos();
            m.TopLevel = false;
            m.Dock = DockStyle.Fill;
            panel1.Controls.Add(m);
            m.BringToFront();
            m.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            masterMenu c = new masterMenu();
            panel3.Height = button2.Height;
            panel3.Top = button2.Top;
            c.Dock = DockStyle.Fill;
            panel1.Controls.Add(c);
            c.BringToFront();
            c.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            successTransaction c = new successTransaction();
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
            c.Dock = DockStyle.Fill;
            panel1.Controls.Add(c);
            c.BringToFront();
            c.Show();

            Form background = new Form
            {
                StartPosition = FormStartPosition.Manual,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = 0.7d,
                BackColor = Color.Black,
                WindowState = FormWindowState.Maximized,
                TopMost = true,
                Location = this.Location,
                ShowInTaskbar = false,
            };

            /* inputPin payForm = new inputPin();
             background.Show();
             payForm.Owner = background;
             payForm.ShowDialog();
             background.Dispose();*/
        }


    }
}