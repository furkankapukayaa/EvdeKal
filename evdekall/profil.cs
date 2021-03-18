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
            yenimenu yenimenu = new yenimenu();
            yenimenu.Show();
            this.Close();
        }

        private void profil_Load(object sender, EventArgs e)
        {
            adsoyad.Text = giris.gonderAd.ToUpper() + " " + giris.gonderSoyad.ToUpper();
            yas.Text = giris.gonderYas + " Yaşındasın!";
            adsoyad.TextAlign = HorizontalAlignment.Center;
            yas.TextAlign = HorizontalAlignment.Center;
            adsoyad.TextAlign = HorizontalAlignment.Center;
            yas.TextAlign = HorizontalAlignment.Center;
        }

        private void izinsorgu_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            if (giris.gonderYas < 20)
            {
                if (dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday)
                {
                    MessageBox.Show(giris.gonderAd.ToUpper() + " Maalesef Dışarı Çıkamazsın!", "Evde Kal");
                    MessageBox.Show("Ama Sana Bir Önerim Var!", "Evde Kal");
                    if (MessageBox.Show("Spor Yapmak,Oyun Oynamak veya Kısa Birkaç Sağlık Testi Yapmak İster Misin ?", "Evde Kal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MessageBox.Show("Tamamdır O Zaman Seni Şimdi Ana Menüye Gönderiyorum :)", "Evde Kal");
                        yenimenu yenimenu = new yenimenu();
                        yenimenu.Show();
                        this.Close();
                        MessageBox.Show("Hadi Kolay Gelsin <3", "Evde Kal");
                    }
                    else
                    {
                        MessageBox.Show("Peki Yine de Bu İmkanlar Ana Menüde Seni Bekliyor Olacak", "Evde Kal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (DateTime.Now.Hour >= 13 && DateTime.Now.Hour < 16)
                    {
                        if (DateTime.Now.Minute >= 00 && DateTime.Now.Second >= 00)
                        {
                           MessageBox.Show("Dışarı Çıkabilirsin.", "Evde Kal");
                        }
                    }
                    else
                    {
                        MessageBox.Show(giris.gonderAd.ToUpper() + " Maalesef Dışarı Çıkamazsın!", "Evde Kal");
                        MessageBox.Show("Ama Sana Bir Önerim Var!", "Evde Kal");
                        if (MessageBox.Show("Spor Yapmak,Oyun Oynamak veya Kısa Birkaç Sağlık Testi Yapmak İster Misin ?", "Evde Kal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            MessageBox.Show("Tamamdır O Zaman Seni Şimdi Ana Menüye Gönderiyorum :)", "Evde Kal");
                            yenimenu yenimenu = new yenimenu();
                            yenimenu.Show();
                            this.Close();
                            MessageBox.Show("Hadi Kolay Gelsin <3", "Evde Kal");
                        }
                        else
                        {
                            MessageBox.Show("Peki Yine de Bu İmkanlar Ana Menüde Seni Bekliyor Olacak", "Evde Kal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }
            else if (giris.gonderYas >= 20 && giris.gonderYas <= 64)
            {
                if (dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday)
                {
                    MessageBox.Show(giris.gonderAd.ToUpper() + " Maalesef Dışarı Çıkamazsın!", "Evde Kal");
                    MessageBox.Show("Ama Sana Bir Önerim Var!", "Evde Kal");
                    if (MessageBox.Show("Spor Yapmak,Oyun Oynamak veya Kısa Birkaç Sağlık Testi Yapmak İster Misin ?", "Evde Kal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MessageBox.Show("Tamamdır O Zaman Seni Şimdi Ana Menüye Gönderiyorum :)", "Evde Kal");
                        yenimenu yenimenu = new yenimenu();
                        yenimenu.Show();
                        this.Close();
                        MessageBox.Show("Hadi Kolay Gelsin <3", "Evde Kal");
                    }
                    else
                    {
                        MessageBox.Show("Peki Yine de Bu İmkanlar Ana Menüde Seni Bekliyor Olacak", "Evde Kal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (DateTime.Now.Hour >= 05 && DateTime.Now.Hour < 21)
                    {
                        if (DateTime.Now.Minute >= 00 && DateTime.Now.Second >= 00)
                        {
                            MessageBox.Show("Dışarı Çıkabilirsin.", "Evde Kal");
                        }
                    }
                    else
                    {
                        MessageBox.Show(giris.gonderAd.ToUpper() + " Maalesef Dışarı Çıkamazsın!", "Evde Kal");
                        MessageBox.Show("Ama Sana Bir Önerim Var!", "Evde Kal");
                        if (MessageBox.Show("Spor Yapmak,Oyun Oynamak veya Kısa Birkaç Sağlık Testi Yapmak İster Misin ?", "Evde Kal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            MessageBox.Show("Tamamdır O Zaman Seni Şimdi Ana Menüye Gönderiyorum :)", "Evde Kal");
                            yenimenu yenimenu = new yenimenu();
                            yenimenu.Show();
                            this.Close();
                            MessageBox.Show("Hadi Kolay Gelsin <3", "Evde Kal");
                        }
                        else
                        {
                            MessageBox.Show("Peki Yine de Bu İmkanlar Ana Menüde Seni Bekliyor Olacak", "Evde Kal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                if (dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday)
                {
                    MessageBox.Show(giris.gonderAd.ToUpper() + " Maalesef Dışarı Çıkamazsın!", "Evde Kal");
                    MessageBox.Show("Ama Sana Bir Önerim Var!", "Evde Kal");
                    if (MessageBox.Show("Spor Yapmak,Oyun Oynamak veya Kısa Birkaç Sağlık Testi Yapmak İster Misin ?", "Evde Kal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MessageBox.Show("Tamamdır O Zaman Seni Şimdi Ana Menüye Gönderiyorum :)", "Evde Kal");
                        yenimenu yenimenu = new yenimenu();
                        yenimenu.Show();
                        this.Close();
                        MessageBox.Show("Hadi Kolay Gelsin <3", "Evde Kal");
                    }
                    else
                    {
                        MessageBox.Show("Peki Yine de Bu İmkanlar Ana Menüde Seni Bekliyor Olacak", "Evde Kal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (DateTime.Now.Hour >= 10 && DateTime.Now.Hour < 13)
                    {
                        if (DateTime.Now.Minute >= 00 && DateTime.Now.Second >= 00)
                        {
                            MessageBox.Show("Dışarı Çıkabilirsin.", "Evde Kal");
                        }
                    }
                    else
                    {
                        MessageBox.Show(giris.gonderAd.ToUpper() + " Maalesef Dışarı Çıkamazsın!", "Evde Kal");
                        MessageBox.Show("Ama Sana Bir Önerim Var!", "Evde Kal");
                        if (MessageBox.Show("Spor Yapmak,Oyun Oynamak veya Kısa Birkaç Sağlık Testi Yapmak İster Misin ?", "Evde Kal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            MessageBox.Show("Tamamdır O Zaman Seni Şimdi Ana Menüye Gönderiyorum :)", "Evde Kal");
                            yenimenu yenimenu = new yenimenu();
                            yenimenu.Show();
                            this.Close();
                            MessageBox.Show("Hadi Kolay Gelsin <3", "Evde Kal");
                        }
                        else
                        {
                            MessageBox.Show("Peki Yine de Bu İmkanlar Ana Menüde Seni Bekliyor Olacak", "Evde Kal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

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
