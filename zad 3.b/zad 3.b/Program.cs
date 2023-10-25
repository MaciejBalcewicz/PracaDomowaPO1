using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3.b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź liczbę 1");
            int liczba1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź liczbę 2");
            int liczba2 = int.Parse(Console.ReadLine());

            if (liczba1 % 2 != 0)
            {
                liczba1 = liczba1 + 1;
            }

            if (liczba2 % 2 != 0)
            {
                liczba2 = liczba2 - 1;
            }

            Console.Write("Liczby parzyste: ");
            for (int i = liczba1; i <= liczba2; i += 2)
            {
                Console.Write(i + ",");
            }

            Console.ReadKey();
        }
    }
}
