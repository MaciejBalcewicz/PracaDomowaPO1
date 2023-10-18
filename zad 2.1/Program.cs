using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj temperature w stopniach Celsjusza");
        double Celsjusz = double.Parse(Console.ReadLine());
        double F = 32.0 + (9.0 / 5.0) * Celsjusz;
        Console.WriteLine(F);
        Console.ReadKey();
    }
}
