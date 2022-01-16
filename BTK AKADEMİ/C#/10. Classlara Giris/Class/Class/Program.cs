using System;
using System.Linq;

namespace Class
{
    class Program:IDisposable
    {


        int[] dizi = { 1, 2, 3 };
        static void altsatiragec()
        {
            using (Program p = new Program())
            {
                foreach (var item in (p.dizi))
                {
                    Console.WriteLine();
                }
            }
            
        }


        static void Main(string[] args)
        {

            /*
             Yapmak istediğimiz işlemleri guruplara ayırmak,

             bu grup üzerinden işlemlerimiz yapmak

             ve rahatlıkla bu gruba ulaşmak için kullanılabilmektedir.
            

            Üretim maliyetlerini  azaltmak , kodları yeniden revize etmek  için kolaylık sağlamamamaktkadır .
            */

            // bir sınıfı kullanabilmemiz için eğer statik değilse bir örneğini (nesnesini) oluşturmamız gerekmektedir. 

            // fonkisyonlar program içeriisnde alt alta yazılabileceği gibi classlib üzerinden sağ tık yeni class denerekte eklenebilir

            // başına public yazılmayan şeyler private dir ve erişim nesne oluşturulsa bile public bir belirteci olan fonksiyon içerisinde çağırılması gerekmektedir .başka türlü ulaşılamaz.





            CostumerManager musteri = new CostumerManager();
            musteri.add();
            musteri.update();
            musteri.delete();

            Program.altsatiragec();

         


            ProductManager urun = new ProductManager();
            urun.add();
            urun.update();
            urun.delete();

            Program.altsatiragec();

            Harici h = new Harici();


            h.GETLISETLI(1);
            h.GETLISETLI(2);


            Console.ReadLine();

            // sınıfların bir guruplama tekniği anlamında methodlarla kullanilabilmektedir.

            // bir diğer özellik ise property denilen nesneleri tutmasıdır. 

            // property isimli oluşturulan sınıf buna bir örnektir. 

            // public int MyProperty { get; set; }

            // yukarıdaki bir property dir. get ve set ile içerisinden değer dönen bir yapıdır. 

            // değişken tanımlamaya benzer özünde fakat kapsülleme içermektedir. Bu sebeple kendisine Özellikler denmektedir. 

            Property pr = new Property(); // proplara gene erişim için static olmamalarından ötürü nesne ile erişim sağlanması gerekmektedir.
            pr.ID = 1;
            pr.lastname = "Akar";
            pr.Firstname = "Berkay";
            Property.city = "Balıkesir";

            // görüldüğü üzere erişim static olduğundan ötürü sadece sınıf ismi ile direk bir erişim sağladık.

            // aynı şekilde bir alttaki deklerasyon ile de mümkün kılınmaktadır. 

            Property prp = new Property
            {
                ID = 2,
                Firstname = "Ahmet",
                lastname = "Demir"
            };

            // ikisininde yazımı aynıdır. üstteki nesneni üzerine gelip use object initializer e gelerekte kaba kodu clean koda derleyici vasıtası ile çevirebiliriz.



            ntetettte




        }

        public void Dispose()
        {
            Console.WriteLine("Siliniyor");
        }
    }

    class CostumerManager
    {
        // müşteri ile ilgili işlemler konabilmektedir

        public void add()
        {
            Console.WriteLine("Müşteri eklendi");
        }

        public void delete()
        {
            Console.WriteLine("Müşteri silindi");
        }

        public void update()
        {
            Console.WriteLine("Müşteri bilgileri güncellendi.");
        }


    }

    class ProductManager
    {
        // müşteri ile ilgili işlemler konabilmektedir

        public void add()
        {
            Console.WriteLine("Ürün eklendi");
        }

        public void delete()
        {
            Console.WriteLine("Ürün silindi");
        }

        public void update()
        {
            Console.WriteLine("Ürün bilgileri güncellendi.");
        }


    }




}
