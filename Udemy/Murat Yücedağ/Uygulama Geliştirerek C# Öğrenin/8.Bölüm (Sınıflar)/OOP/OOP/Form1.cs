using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP.Siniflar;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

         
        }
        OpenFileDialog file = new OpenFileDialog();

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            file.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            try
            {
                Araba yeniaraba = new Araba();
                yeniaraba.Marka = (textBox1.Text).Trim().ToUpper();
                yeniaraba.Model1 = (textBox2.Text).Trim().ToUpper();
                yeniaraba.Renk1 = (comboBox1.SelectedItem.ToString()).Trim().ToUpper();
                yeniaraba.Resim = file.FileName;
                yeniaraba.Fiyat1 = Convert.ToInt32((textBox6.Text).Trim().ToUpper());
                yeniaraba.Kaydet(yeniaraba);
            }
            catch (ArgumentException arg)
            {
                MessageBox.Show(arg.Message);
            }

         }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
    }
}
