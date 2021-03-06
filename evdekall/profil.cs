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
    public partial class profil : Form
    {
        public profil()
        {
            InitializeComponent();
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

        private void profil_Load(object sender, EventArgs e)
        {
            adsoyad.Text = giris.gonderAd.ToUpper() + " " + giris.gonderSoyad.ToUpper();
            yas.Text = giris.gonderYas + " Yaşındasınız!";
            adsoyad.TextAlign = HorizontalAlignment.Center;
            yas.TextAlign = HorizontalAlignment.Center;
            adsoyad.TextAlign = HorizontalAlignment.Center;
            yas.TextAlign = HorizontalAlignment.Center;
        }

        private void izinsorgu_Click(object sender, EventArgs e)
        {

            if (giris.gonderYas < 20)
            {
                yirmiyasalti yirmiyasalti = new yirmiyasalti();
                yirmiyasalti.Show();
                this.Close();
            }
            else if (giris.gonderYas >= 20 && giris.gonderYas <= 64)
            {
                yirmibirvealtmisdortarasi yirmibirvealtmisdortarasi = new yirmibirvealtmisdortarasi();
                yirmibirvealtmisdortarasi.Show();
                this.Close();
            }
            else
            {
                altmisbesuzeri altmisbesuzeri = new altmisbesuzeri();
                altmisbesuzeri.Show();
                this.Close();
            }

        }

        private void saglik_Click(object sender, EventArgs e)
        {
            saglik saglik = new saglik();
            saglik.Show();
            this.Close();
        }

        int mov, movX, movY;

        private void hareket_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void spor_Click(object sender, EventArgs e)
        {
            spor spor = new spor();
            spor.Show();
            this.Close();
        }

        private void oyun_Click(object sender, EventArgs e)
        {
            oyun oyun = new oyun();
            oyun.Show();
            this.Close();
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
