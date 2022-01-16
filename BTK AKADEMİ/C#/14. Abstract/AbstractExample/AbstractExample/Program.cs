using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    class Program
    {
        static void Main(string[] args)
        {
            /*          Abstract Sınıflar           */

            /*
             
             İnterfacelerde Amacımız imzaları oluşturmak ve onu implamente (kalıtım eden ) sınıfın bütün imzalarını yazması (override etmesi) sağlanmasıydı. Bu implamente edilmesi gerekmektedir. 

            virtual olan methhodlar isteğe bağlı olarak kalıtım verilirken override edilebilirken (sınıfa gre isteğe bağlı) eğer override edilmiyor ise ana sınıftaki fonksiyonu bierbir olarak kullanabilmemize olanak sağlamaktaydı. 

            Abstrat classlarda zünde birer sınıftır. 

              
            Abstrat sınıflar virtual methodlar + interfaceler olarak düşünülebilmektedir.

            Kısacası İnterfaceler ile virtual methodları bir araya getirtecek sebeplerde tanımlamanabilir ve kalıtım aldırtmak amacı ile kullanılmaktadır. 


            abstract class Database { } şekinde bir deklerasyon u vardır.   

             
        public abstract void Update(); şeklinde abstract fonkisyonlar tannımlamamız ise kalıtım alan sınıfta ezilme zorunlulugu getirmektedir. İnterface gibi body siz yazılmaktadır. 

            abstarct demek içi dolu olmayan virtaul methodtur.
            
            abstract olarak abstarct sınıf içerisindeki yapılan tanımlamalar sonucunda kalıtım verildiği an interface gibi davranım aşağı implamente edilmeli ve ezilmelidir. 

            Seneryo üzerinden kurmak gerekirse connection stringinin propu bu şekilde tanımlanabilir çünkü her bir database için ekleme güncelleme silme grüntüleme aynı iken her bir veri tabanının connection stringi farklılık içereceğinden türü orada get ile string belirtilmelidir. 


             İnterfacelerde olduğu gibi abstract calsslarda newlenemez.

            Haliyle nesne de üretilemez

            Abstact classlarda ornektede gorülebileceği gibi herkez için ortak olan ozellikler ve değişkenler (methodlar) ortaksa burada tanımlanarak kalıtım verilir ortak olmayanlarda ezilmesi gerekmektedir. 


             */

        }
    }

    abstract class Database {

        public void Add() {
            Console.WriteLine("ABSTRACT ADDED");
        }

        public abstract void Update();
    
    }


    //public class SQlserver : Database
    //{
    //    public override void Update()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //public class Oracle : Database
    //{
    //    public override void Update()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
