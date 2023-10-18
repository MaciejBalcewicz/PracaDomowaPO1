using System;

namespace Zad_2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            // a
            int x = 1, y = 4, z = 2;
            bool wynikA = (x++ > 1 && y++ == 4 && z-- > 0);
            Console.WriteLine("wynikA={0} x={1} y={2} z={3}", wynikA, x, y, z);

            // b
            x = 1; y = 4; z = 2; 
            bool wynikB = (x++ > 1 & y++ == 4 && z-- > 0);
            Console.WriteLine("wynikB={0} x={1} y={2} z={3}", wynikB, x, y, z);

            // c
            x = 1; y = 4; z = 2; 
            bool wynikC = (x++ > 1 & y++ == 4 & z-- > 0);
            Console.WriteLine("wynikC={0} x={1} y={2} z={3}", wynikC, x, y, z);

            // d
            x = 1; y = 3; z = 4; 
            bool wynikD = (x == 1 || y++ > 2 || ++z > 0);
            Console.WriteLine("wynikD={0} x={1} y={2} z={3}", wynikD, x, y, z);

            // e
            x = 1; y = 3; z = 4; 
            bool wynikE = (x == 1 | y++ > 2 || ++z > 0);
            Console.WriteLine("wynikE={0} x={1} y={2} z={3}", wynikE, x, y, z);

            // f
            x = 1; y = 3; z = 4; 
            bool wynikF = (x == 1 | y++ > 2 | ++z > 0);
            Console.WriteLine("wynikF={0} x={1} y={2} z={3}", wynikF, x, y, z);
            Console.ReadLine();
        }
       
    }
}
