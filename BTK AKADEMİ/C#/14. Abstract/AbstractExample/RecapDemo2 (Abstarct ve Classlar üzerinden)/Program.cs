using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2__Abstarct_ve_Classlar_üzerinden_
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class CostumerManager
    {   
        public void Add()
        {
            Logging log = new Logging();
            log.LOG();
            Console.WriteLine("Eklendi");
        }
     
    }
    public class Logging
    {
        public void LOG()
        {
            Console.WriteLine("LOG GERÇEKLEŞTİ");
        }

    }
}
