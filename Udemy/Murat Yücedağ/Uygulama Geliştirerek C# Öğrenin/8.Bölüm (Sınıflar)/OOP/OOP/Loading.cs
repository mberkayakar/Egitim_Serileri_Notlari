using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int sayac = 0;

        private void Loading_Load(object sender, EventArgs e)
        {
            labelControl1.Visible = false;
            this.FormBorderStyle = FormBorderStyle.None;
            timer1.Interval = 30;
            timer1.Start();
            timer2.Interval = 500;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (sayac < 100)
            {
                sayac++;
                progressBar1.Value++;
            }
            else if (sayac == 100)
            {
                progressBar1.Value = 100;
                progressBar1.Visible = false;
                labelControl1.Visible = true;
                timer1.Stop();
                timer2.Start();
            }

        }
        int timer2sayac = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {

            if (timer2sayac < 5)
            {



                if (timer2sayac % 2 == 0)
                {
                    labelControl1.Visible = true;
                    timer2sayac++;
                }
                else if (timer2sayac % 2 == 1)
                {
                    labelControl1.Visible = false;
                    timer2sayac++;

                }
            }
            else
            {
                timer2.Stop();
                Giriş_Ekrani giris = new Giriş_Ekrani();
                this.Visible = false;
                giris.Visible = true;

            }
        }
    }
}
