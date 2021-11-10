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
    public partial class anamenu : Form
    {
        public anamenu()
        {
            InitializeComponent();
        }

        private void anamenu_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tarih.Text = DateTime.Now.ToLongDateString() + "\n" + DateTime.Now.ToLongTimeString();
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

        int mov, movX, movY;

        private void hareket_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        
        private void KoronaHaber_Click(object sender, EventArgs e)
        {
            koronahaber koronahaber = new koronahaber();
            koronahaber.Show();
        }

        private void KoronaTablo_Click(object sender, EventArgs e)
        {
            koronatablo koronatablo = new koronatablo();
            koronatablo.Show();
        }

        private void YirmiYasAlti_Click(object sender, EventArgs e)
        {
            yirmiyasalti yirmiyasalti = new yirmiyasalti();
            yirmiyasalti.Show();
            this.Close();
        }

        private void YirmiBirAltmisDortArasi_Click(object sender, EventArgs e)
        {
            yirmivealtmisdortarasi yirmivealtmisdortarasi = new yirmivealtmisdortarasi();
            yirmivealtmisdortarasi.Show();
            this.Close();
        }

        private void AltmisBesUzeri_Click(object sender, EventArgs e)
        {
            altmisbesuzeri altmisbesuzeri = new altmisbesuzeri();
            altmisbesuzeri.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            asitablo asitablo = new asitablo();
            asitablo.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            harita harita = new harita();
            harita.Show();
            this.Close();
        }

        private void kural14_Click(object sender, EventArgs e)
        {
            _14kural _14kural = new _14kural();
            _14kural.Show();
        }

        private void hareket_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void hareket_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
