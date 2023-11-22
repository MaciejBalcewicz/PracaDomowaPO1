using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dlugosc i szerokosc prostokata:");
            double dlugosc = double.Parse(Console.ReadLine());
            double szerokosc = double.Parse(Console.ReadLine());
            Console.WriteLine("Znak jakim ma byc zapelniony prostokat:");
            char znak = Console.ReadKey().KeyChar;
            Console.WriteLine();
            rysuj(dlugosc,szerokosc,znak);

            Console.ReadLine();
        
        }
        static void rysuj(double dlugosc,double szerokosc,char znak)
        {for (int i = 0; i < dlugosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                { Console.Write(znak); }
                Console.WriteLine();
            }
         }
    }
}
