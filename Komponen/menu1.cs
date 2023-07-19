using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KASIR.komponen
{
    public partial class menu1 : UserControl
    {
        public menu1()
        {
            InitializeComponent();
        }



        private void widget1_Load_1(object sender, EventArgs e)
        {
            dtlPesanan dtl = new dtlPesanan();



            dtl.Show();
        }
    }
}
