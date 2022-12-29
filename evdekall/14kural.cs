using System;
using System.Windows.Forms;

namespace evdekall
{
    public partial class _14kural : Form
    {
        public _14kural()
        {
            InitializeComponent();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            _14kural _14kural = new _14kural();
            this.Close();
        }

        private int mov, movX, movY;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
    }
}