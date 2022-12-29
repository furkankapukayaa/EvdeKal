using System;
using System.Windows.Forms;

namespace evdekall
{
    public partial class spor : Form
    {
        public spor()
        {
            InitializeComponent();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            yenimenu yenimenu = new yenimenu();
            yenimenu.Show();
            this.Close();
        }

        private void kucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private int mov, movX, movY;

        private void hareket_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void evdespor_Click(object sender, EventArgs e)
        {
            evdesporyapmak evdesporyapmak = new evdesporyapmak();
            evdesporyapmak.Show();
        }

        private void hareket_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void hareket_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}