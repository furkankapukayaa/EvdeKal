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
    public partial class girisbildirim : Form
    {
        public girisbildirim()
        {
            InitializeComponent();
        }

        public enum enumAction
        {
            wait,
            start,
            close
        }

        private girisbildirim.enumAction action;
        private int x, y;

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enumAction.wait:
                    timer1.Interval = 5000;
                    action = enumAction.close;
                    break;
                case enumAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = enumAction.wait;
                        }
                    }
                    break;
                case enumAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();

                    }
                    break;

            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enumAction.close;
        }

        private void girisbildirim_Load(object sender, EventArgs e)
        {
            this.Left = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right - this.Width;
            this.Top = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - this.Width/4;
        }

        public void UyariGoster(string msg)
        {
            this.Opacity = 0.0;
            string fname;

            for (int i = 0; i < 10; i++)
            {
                fname = "Uyarı" + i.ToString();
                girisbildirim girisbildirim = (girisbildirim)Application.OpenForms[fname];
                if (girisbildirim == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 30;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Width * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            this.label1.Text = msg;
            this.Show();
            this.action = enumAction.start;
            this.timer1.Interval = 1;
            timer1.Start();
        }
    }
}
