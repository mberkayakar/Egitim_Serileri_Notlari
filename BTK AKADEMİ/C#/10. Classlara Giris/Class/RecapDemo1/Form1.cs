using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            /*
             
                Button buton1 = new Button();
                buton1.Text = "";
                buton1.Width = 50;
                buton1.Height = 50;
                buton1.Visible = true;
                buton1.BackColor = Color.Red;
                buton1.Left = i+50;
                this.Controls.Add(buton1);
             
             
             */


            // Butonların her birine ayrı ayrı erişebilmek istiyorsanız button nesnesinden array oluşurabilirsiniz

            // Yukarıdaki tanımlamalar ile oluşturulan her bir button nesnesi için el ile atamalar yapmak mümkündür. 
            
            // erişim kolaylığı açısından biz bu şekilde bir erişim yapmayı uygun gördük yani form objelerine diziler üzerinden bir erişim gerçekleştirilecektir 


            Button[,] butonlar = new Button[8,8];

            int top = 0;
            int left = 0;
            int sayac = 1;

            
            
            for (int i = 0;  i < butonlar.GetUpperBound(0); i++)
            {
                for (int j = 0; j < butonlar.GetUpperBound(1); j++)
                {
                 

                    butonlar[i,j] = new Button();
                    if ((j+i)%2==0)
                    {
                        butonlar[i, j].BackColor = Color.Black;
                        butonlar[i, j].ForeColor = Color.White;
                    }
                   
                    
                    butonlar[i, j].Width = 50;
                    butonlar[i, j].Height = 50;
                    butonlar[i, j].Top= top;
                    butonlar[i, j].Left= left;
                    butonlar[i, j].Text= sayac.ToString();
                    sayac++;
                    
                    left += 100;
                    this.Controls.Add(butonlar[i, j]);
                
                }
                top += 100;
                left = 0;
            }

            
           

            int genislik =Convert.ToInt32( butonlar[butonlar.GetUpperBound(0)-1, butonlar.GetUpperBound(1)-1].Width.ToString());
            int yukseklik = Convert.ToInt32(butonlar[butonlar.GetUpperBound(0) - 1, butonlar.GetUpperBound(1) - 1].Top.ToString());
            this.Width = genislik+300;
            this.Height = yukseklik+100;
        
        }
    }
}
