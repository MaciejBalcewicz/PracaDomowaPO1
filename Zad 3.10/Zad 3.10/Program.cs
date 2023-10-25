using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj wartość n, dla której obliczymy n!: ");
        int n;

        if (int.TryParse(Console.ReadLine(), out n))
        {
            if (n < 0)
            {
                Console.WriteLine("Silnia nie jest zdefiniowana dla liczb ujemnych.");
            }
            else
            {
                long factorial = CalculateFactorial(n);
                Console.WriteLine($"{n}! = {factorial}");
            }
        }
        else
        {
            Console.WriteLine("Nieprawidłowa wartość n.");
        }
    }

    static long CalculateFactorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }

        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
        Console.WriteLine(result);
        Console.ReadLine();

    }
  
}
