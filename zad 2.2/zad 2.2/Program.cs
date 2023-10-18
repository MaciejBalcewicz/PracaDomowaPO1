using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Oblicz deltę dla równania kwadratowego ax^2 + bx + c = 0");

        Console.Write("Podaj współczynnik a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Podaj współczynnik b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Podaj współczynnik c: ");
        double c = double.Parse(Console.ReadLine());

        double delta = b * b - 4 * a * c;

        Console.WriteLine($"Delta wynosi: {delta}");

        if (delta > 0)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Równanie ma dwa pierwiastki rzeczywiste: x1 = {x1}, x2 = {x2}");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Równanie ma jeden pierwiastek rzeczywisty: x = {x}");
        }
        else
        {
            Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych.");
        }

        Console.ReadLine();
    }
}