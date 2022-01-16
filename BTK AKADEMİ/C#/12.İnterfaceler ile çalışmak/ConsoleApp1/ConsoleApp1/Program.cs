using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        interface IPerson  // yazım yapısı aynı class a benzer
        {
            int Id { get; set; }
        }

        class Costumer : IPerson
        {
            public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }

        class Student : IPerson
        {
            public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }

        static void Main(string[] args)
        {
            /*    İnterFaceler     */

            /*
             
             
             
             
             
             
             
             */
        }
    }
}
