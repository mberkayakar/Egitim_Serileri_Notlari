using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace OOP.Siniflar
{
    class Araba
    {
        private string marka;
        private string Model;
        private string Renk;
        private int Fiyat;
        private string resim;

        public static List<Araba> sayilar = new List<Araba>();

        static int sayac = 0;
        public string Model1
        {
            get { return Model; }
            set {
                if (value != "")
                    Model = value;
                else
                    throw new ArgumentException("Lütfen Model Bilgisini Boş Geçmeyiniz");
            }
        }


        public string Renk1
        {
            get { return Renk; }
            set
            {
                if (value != "")
                    Renk = value;
                else
                    throw new ArgumentException("Lütfen Renk Bilgisini Boş Geçmeyiniz");
            }
        }

        public int Fiyat1
        {
            get { return Fiyat; }
            set
            {
                if (value != 0 && value > 0)
                    Fiyat = value;
                else
                    throw new ArgumentException("Lütfen Kabul Edilebilir Bir Sayı Giriniz");
            }
        }
        public string Resim {
            get { return resim; }
            set
            {
                if (value != "")
                    resim = value;
                else
                    throw new ArgumentException("Lütfen Resim Seçiniz");
            }
        }
        public string Marka {
            get { return marka; }
            set
            {
                if (value != "")
                    marka = value;
                else
                    throw new ArgumentException("Lütfen Marka Bilgisi Giriniz");
            }
        }


       public void Kaydet(Araba arabalar)
        {
             
                try
                {
                sayilar.Add(arabalar);
                }
                catch (ArgumentException arg)
                {

                    MessageBox.Show(arg.Message);
                }
           
 

           
     
        }
    }
}
