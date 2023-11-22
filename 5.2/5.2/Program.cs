using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj trzy liczby rzeczywiste: ");

        Console.Write("Podaj a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        bool wynik = SprawdzPrzedzial(a, b, x);
        Console.WriteLine($"Czy {x} należy do przedziału ({a}, {b})? {wynik}");
        Console.ReadLine();
    }

    static bool SprawdzPrzedzial(double a, double b, double x)
    {
        return x > a && x < b;
    }
}