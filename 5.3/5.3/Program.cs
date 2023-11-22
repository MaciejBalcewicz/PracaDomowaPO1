using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int ax = int.Parse(Console.ReadLine());
            int ay = int.Parse(Console.ReadLine());
            przesun(ref ax,ref ay, 10, 20);
            Console.WriteLine($"{ax},{ay}");
            Console.ReadLine();

        }
        static void przesun(ref int ax, ref int ay, int wekx, int weky)
        {
            ax+=wekx;
            ay+=weky;
        }


    }
}
