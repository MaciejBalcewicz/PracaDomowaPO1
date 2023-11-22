using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Oblicz(5));
            Console.ReadLine();
        }
        static int Oblicz(int n)
        {
            if (n <= 1) return (1);
            else return (n + Oblicz(n - 1));
        }
    }
}
