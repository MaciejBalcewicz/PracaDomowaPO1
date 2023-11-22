using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._7
{
    class Program
    { 
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(oblicz(x, n));
            Console.ReadLine();
        }
        static int oblicz(int x, int n)
        {
            int w=0;
            for (int i = 0; i < n; i++)
            { w += x + i; }
            return w;
        }

}
}
