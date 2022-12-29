using System;
using System.Windows.Forms;

namespace evdekall
{
    public partial class hakkimizda : Form
    {
        public hakkimizda()
        {
            InitializeComponent();
        }

        private void kucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            yenimenu yenimenu = new yenimenu();
            yenimenu.Show();
            this.Close();
        }

        private int mov, movX, movY;
        private void hareket_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void github_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/furkankapukayaa/EvdeKal");
        }

        private void paylas_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/furkankapukayaa/EvdeKal");
        }

        private void hareket_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void hareket_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
    }
}