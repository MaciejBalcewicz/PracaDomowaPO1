using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj wagę (w kilogramach):");
        double waga = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj wzrost (w metrach):");
        double wzrost = double.Parse(Console.ReadLine());

        double bmi = waga / (wzrost * wzrost);

        Console.WriteLine("Twój wskaźnik masy ciała (BMI) wynosi: {0}", bmi);
        Console.ReadLine();
    }
}
