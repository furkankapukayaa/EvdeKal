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
    public partial class yenimenu : Form
    {
        public yenimenu()
        {
            InitializeComponent();
        }

        int mov, movX, movY;

        private void hareket_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sağlıklı Günler, Kendine Dikkat Et!", "Görüşürüz", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void kucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void profil_Click(object sender, EventArgs e)
        {
            profil profil = new profil();
            profil.Show();
            this.Close();
        }

        private void yenimenu_Load(object sender, EventArgs e)
        {
            mrbuser.Text = "MERHABA, " + giris.gonderAd.ToUpper() + " " + giris.gonderSoyad.ToUpper();
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(profil, "Profil");
            Aciklama.SetToolTip(hakkimizda, "Bilgi");
        }

        private void korona_Click(object sender, EventArgs e)
        {
            anamenu anamenu = new anamenu();
            anamenu.Show();
            this.Close();
        }

        private void saglik_Click(object sender, EventArgs e)
        {
            saglik saglik = new saglik();
            saglik.Show();
            this.Close();
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

        private void hakkimizda_Click(object sender, EventArgs e)
        {
            hakkimizda hakkimizda = new hakkimizda();
            hakkimizda.Show();
            this.Close();
        }

        private void harita_Click(object sender, EventArgs e)
        {
            harita harita = new harita();
            harita.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _14kural _14kural = new _14kural();
            _14kural.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Testimiz güncelleniyor. Anlayışınız için teşekkür ederiz.");
        }

        private void hareket_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void hareket_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
    }
}
