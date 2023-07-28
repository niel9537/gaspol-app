using KASIR.komponen;

namespace KASIR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel3.Height = button6.Height;
            panel3.Top = button6.Top;
            masterPos m = new masterPos();
            m.TopLevel = false;
            m.Dock = DockStyle.Fill;
            panel1.Controls.Add(m);
            m.BringToFront();
            m.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
    }
}