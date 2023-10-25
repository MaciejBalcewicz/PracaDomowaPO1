using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3.c
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            double dlug = 80, zarobekJanka = 50, zarobekKarola = 40;
            double splata = 0;

            do
            {
                splata += 0.2 * zarobekJanka + 0.2 * zarobekKarola;
                Console.WriteLine("Dzień = {0} Spłata = {1}", i++, splata);
            } while (dlug > splata);

            Console.ReadKey();
        }
    }
}
