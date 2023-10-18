using System;

namespace zad_2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x;
            int y = 1, z = 1;
            x = (y == 1 && z++ == 1);

            Console.WriteLine($"x: {x}, y: {y}, z: {z}");
            Console.ReadLine();
        }
    }
}
