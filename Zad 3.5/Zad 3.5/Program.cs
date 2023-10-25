using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj współczynnik a:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj współczynnik b:");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj współczynnik c:");
        double c = double.Parse(Console.ReadLine());

        double delta = b * b - 4 * a * c;

        if (delta > 0)
        {
            Console.WriteLine("Równanie ma dwa pierwiastki rzeczywiste.");
        }
        else if (delta == 0)
        {
            Console.WriteLine("Równanie ma jeden pierwiastek rzeczywisty.");
        }
        else
        {
            Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych.");
        }
        Console.ReadLine();
    }
}

