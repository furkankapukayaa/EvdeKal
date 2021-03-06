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
    public partial class butonuyakala : Form
    {
        public butonuyakala()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TEBRİKLER");
            oyun oyun = new oyun();
            oyun.Show();
            this.Hide();
        }

        Random r = new Random();
        int boyut = 50;
        private void button1_MouseHover(object sender, EventArgs e)
        {
            boyut += -1;
            yakala.Top = r.Next(0, this.Height - 50);
            yakala.Left = r.Next(0, this.Width - 50);
            yakala.Width = boyut;
            yakala.Height = boyut;
        }

        private void butonuyakala_FormClosed(object sender, FormClosedEventArgs e)
        {
            oyun oyun = new oyun();
            oyun.Show();
        }

    }
}
