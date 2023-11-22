using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj n:");
            int n = int.Parse(Console.ReadLine());

            int wynikRekurencyjny = FibonacciRekurencyjny(n);
            Console.WriteLine($"Wynik (rekurencyjnie): {wynikRekurencyjny}");

            int wynikIteracyjny = FibonacciIteracyjny(n);
            Console.WriteLine($"Wynik (iteracyjnie): {wynikIteracyjny}");

            Console.ReadLine();
        }

        static int FibonacciRekurencyjny(int n)
        {
            if (n <= 1)
                return n;
            else
                return FibonacciRekurencyjny(n - 1) + FibonacciRekurencyjny(n - 2);
        }

        static int FibonacciIteracyjny(int n)
        {
            if (n <= 1)
                return n;

            int pierwszy = 0, drugi = 1, wynik = 0;

            for (int i = 2; i <= n; i++)
            {
                wynik = pierwszy + drugi;
                pierwszy = drugi;
                drugi = wynik;
            }

            return wynik;
        }
    }
}
