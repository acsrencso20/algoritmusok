using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxkivalasztas
{
    class Program
    {
        static void Main(string[] args)
        {

            Random veletlen = new Random();
                      
            int max = 0;
            
            int [] tomb = new int [50];

            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = veletlen.Next(1, 101);
                if (tomb[i] > max) max = tomb[i];
                Console.Write("\t{0}",tomb[i]);
            }
            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine("\n{0}",max);

            Console.ReadKey();
        }
    }
}
