using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonksiyonlar_Egitim
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             
            
                                     C# Temel Prosedürel Programlama
             
                                         C# 9.0 a kadarı işlenmiştir.

            
            
            * Methodlara Yordam veya Yöntem denebilmektedir. 
            
            * İngilizcesi Function dur. 
            
            * Yazılımda (fiili olarak) gerçekleştirdiğimiz tüm operasyonlar bir methoddur.
            
            * Matematikteki fonksiyonlar yazılımdaki methodlara eşdeğerdir.
            
            * f(x) = 5*x ..... Benim elimde x diye bir method olacak bu method sırası ile şu operasyonları gerçekleştirecektir.
            
            * Yazılımda bir fiiliyat gerçekleştilecekse bir 
            
            * Method prosedürel programlamanın temel elemanıdır.
            
            * OOP nin temel üyesidir.
            
            * Bir iş, operasyon yapan en küçük program parçacıklarıdır.
            
            * Yazılım içerisinde algoritmayı fiiliyatı çalıştırabileceğin tek yerdir.
            
            * Methodun içerisine kod yazılabilir sadece .
            
            * Method dışında sadece deklerasyonlar tanımlanmaktadır.
            
            * Algoritma ve çeşitli kod yapıları ile iş yaptırtmadır. Bir işe adanmış olan yapıdır.
            
            
             */

            #region İkinci_Ders

            /*
             
            Method prosedürel programlamanın temel elemanıdır

            Bir iş yapan en küçük program parçacığıdır.

            Bu iş algoritma veya operasyon , eylem olabilir.

            void main de bir maindir.

            Methodlar bizlerin tekrara düşmesini engeller. Kod içerisindeki tekrarları ortadan kaldırmamız yaramaktadır.

            Tek sefer inşaa edip çağırarak aynı işlemlerin tekarlarını sağlayabilmekteyiz.
            


             
             */

            #endregion

            int[] sayilar = new int[10];

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = new Random().Next() ;
            }

            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }


            // yukarıdaki kod 10 elemanlı bir dizi açarak içerisinde random sayı yazdırmamızı sağlar. Bu kodun çeşitli yerlerde tekrar tekrar çalışmasını sağlamak istiyorsak bir method içerisinde tanımlar ve bu yapıyı istenilen yerlerde tekrar tekrar çağırabiliriz.

            // kod içerisinde tekrar yapmak yönetilebilirliği zayıflatacaktır. Fonksiyonlara Aktarmak yönetilebilirliği arttıracaktır. 
        }
    }
}
