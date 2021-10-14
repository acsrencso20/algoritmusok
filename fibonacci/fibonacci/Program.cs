using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
   class Program

    {
        public static int fib(int szam)                   
        {
            if (szam <= 1) return 1;
            else return fib(szam - 2) + fib(szam - 1);
        }

        static void Main(string[] args)

        {
            
            int osszeg;

            do

            {
            Console.WriteLine("Meddig adjuk össze a számokat?");

            } while (!(int.TryParse(Console.ReadLine(), out osszeg)));

            for (int i = 0; i < osszeg; i++) Console.Write("{0} ", fib(i));


            Console.ReadKey();



        }

    }

}

