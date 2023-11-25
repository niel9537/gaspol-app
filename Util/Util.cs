using KASIR.Komponen;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Util
    {
        // Your other utility functions here
        blur background = new blur();
        public void ShowBlurredDialog(Form formToShow)
        {
            background.StartPosition = FormStartPosition.CenterScreen;
            background.FormBorderStyle = FormBorderStyle.None;
            background.Opacity = 0.7d;
            background.BackColor = Color.Black;
            background.WindowState = FormWindowState.Maximized;
            background.TopMost = true;
            background.Size = formToShow.Size;
            background.Location = formToShow.Location;
            background.ShowInTaskbar = false;
            background.Show();
            formToShow.Owner = background;
            formToShow.ShowDialog();
            background.Dispose();
        }

        
    }