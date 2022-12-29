using System;
using System.Windows.Forms;

namespace evdekall
{
    public partial class vki : Form
    {
        public vki()
        {
            InitializeComponent();
        }

        private double vihesapla(double boy, double kilo)
        {
            return kilo / (boy * boy);
        }
        private void vucutindeks(double boy, double kilo)
        {
            double sonuc = vihesapla(boy / 100, kilo);
            sonuc = NewMethod(sonuc);
            double kiloal = 18.5 - sonuc;
            double kiloalhesap = ((kiloal * (boy * boy)) / 100) / 100;
            double kilover = sonuc - 25;
            double kiloverhesap = ((kilover * (boy * boy)) / 100) / 100;
            if (sonuc <= 18.4)
            {
                listBox1.Items.Add("Vücut İndeksiniz : " + sonuc);
                listBox1.Items.Add("Zayıf : 0 - 18.4 Kategorisindesiniz.");
                listBox1.Items.Add(kiloalhesap + " Kilo Alman Gerekiyor");
            }

            if (sonuc >= 18.5 && sonuc <= 24.9)
            {
                listBox1.Items.Add("Vücut İndeksiniz : " + sonuc);
                listBox1.Items.Add("Normal : 18.5-24.9 Kategorisindesiniz.");
            }

            if (sonuc >= 25 && sonuc <= 29.9)
            {
                listBox1.Items.Add("Vücut İndeksiniz : " + sonuc);
                listBox1.Items.Add("Fazla Kilolu : 25.0-29.9 Kategorisindesiniz.");
                listBox1.Items.Add(kiloalhesap + " Kilo Vermen Gerekiyor");
            }

            if (sonuc >= 30 && sonuc <= 34.9)
            {
                listBox1.Items.Add("Vücut İndeksiniz : " + sonuc);
                listBox1.Items.Add("Şişman(Obez) - 1.Sınıf : 30.0-34.9 Kategorisindesiniz.");
                listBox1.Items.Add(kiloalhesap + " Kilo Vermen Gerekiyor");
            }

            if (sonuc >= 35 && sonuc <= 44.9)
            {
                listBox1.Items.Add("Vücut İndeksiniz : " + sonuc);
                listBox1.Items.Add("Şişman(Obez) - 2.Sınıf : 35.0-44.9 Kategorisindesiniz.");
                listBox1.Items.Add(kiloalhesap + " Kilo Vermen Gerekiyor");
            }

            if (sonuc >= 45)
            {
                listBox1.Items.Add("Vücut İndeksiniz : " + sonuc);
                listBox1.Items.Add("Aşırı Şişman(Obez) - 3.Sınıf : 45.0-ve üstü Kategorisindesiniz.");
                listBox1.Items.Add(kiloalhesap + " Kilo Vermen Gerekiyor");
            }
        }
        private static double NewMethod(double sonuc)
        {
            sonuc = Math.Round(sonuc, 2);
            return sonuc;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (boy.Text == String.Empty || kilo.Text == String.Empty)
            {
                MessageBox.Show("Kutuları Boş Bırakmayınız!", "Boş Alan Hatası!");
            }
            else
            {
                double boy = Convert.ToInt32(this.boy.Text);
                double kilo = Convert.ToInt32(this.kilo.Text);
                double sonuc = vihesapla(boy / 100, kilo);
                vucutindeks(boy, kilo);
            }
        }

        private void vki_Load(object sender, EventArgs e)
        {
            boy.MaxLength = 3;
            kilo.MaxLength = 3;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void kucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            saglik saglik = new saglik();
            saglik.Show();
            this.Close();
        }

        private int mov, movX, movY;

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