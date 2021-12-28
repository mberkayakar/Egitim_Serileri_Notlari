using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Harici
    {

        public void GETLISETLI(int a)
        {
            if (a == 1)
                fonksiyon();
            else
                fonksiyon2() ;
        }
        void fonksiyon()
        {
            Console.WriteLine("Fonkisyon Methodu Çağırıldı dönen değer 1");
        }

         void fonksiyon2()
        {
            Console.WriteLine("Fonkisyon2 Methodu Çağırıldı dönen değer 2");
        }

    }
}
