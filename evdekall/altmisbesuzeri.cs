using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evdekall
{
    public partial class altmisbesuzeri : Form
    {
        public altmisbesuzeri()
        {
            InitializeComponent();
        }

        private void altmisbesuzeri_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            if (dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday)
            {
                sonuc.Text = "Maalesef Dışarı Çıkamazsın!";
                serbest.Visible = false;
                yasak.Visible = true;
            }
            else
            {
                if (DateTime.Now.Hour >= 10 && DateTime.Now.Hour < 13)
                {
                    if (DateTime.Now.Minute >= 00 && DateTime.Now.Second >= 00)
                    {
                        sonuc.Text = "Dışarı Çıkabilirsin.";
                        serbest.Visible = true;
                        yasak.Visible = false;
                    }
                }
                else
                {
                    sonuc.Text = "Maalesef Dışarı Çıkamazsın!";
                    serbest.Visible = false;
                    yasak.Visible = true;
                }
            }
        }

        private void kucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            anamenu anamenu = new anamenu();
            anamenu.Show();
            this.Close();
        }

        int mov, movX, movY;

        private void hareket_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void hareket_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
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
