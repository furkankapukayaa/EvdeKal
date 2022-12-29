using System;
using System.Windows.Forms;

namespace evdekall
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        private void ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
              && !char.IsSeparator(e.KeyChar);
        }

        private void soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
              && !char.IsSeparator(e.KeyChar);
        }

        private void yas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sağlıklı Günler, Kendine Dikkat Et!", "Görüşürüz", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private int mov, movX, movY;

        private void hareket_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void kucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public static string gonderAd = "", gonderSoyad = "";
        public static int gonderYas;
        public void Uyari(string msg)
        {
            girisbildirim girisbildirim = new girisbildirim();
            girisbildirim.UyariGoster(msg);
        }
        private void girisYap_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int yas;

            if (this.ad.Text == string.Empty || this.soyad.Text == string.Empty || this.yas.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Kutuları Boş Bırakmayınız!", "Boş Alan Hatası");
            }
            else
            {
                ad = this.ad.Text;
                soyad = this.soyad.Text;
                yas = int.Parse(this.yas.Text);

                profil profil = new profil();
                gonderAd = ad;
                gonderSoyad = soyad;
                gonderYas = yas;

                //MessageBox.Show("Merhaba " + ad.ToUpper() + " " + soyad.ToUpper() + " Hoş Geldin!", "EvdeKAL!");
                this.Uyari("Merhaba " + ad + " " + soyad + " Hoş Geldin!");
                yenimenu yenimenu = new yenimenu();
                yenimenu.Show();
                this.Hide();
            }
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

        private void giris_Load(object sender, EventArgs e)
        {
            ad.MaxLength = 10;
            soyad.MaxLength = 10;
            yas.MaxLength = 3;
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(girisYap, "Giriş Yap");
        }
    }
}