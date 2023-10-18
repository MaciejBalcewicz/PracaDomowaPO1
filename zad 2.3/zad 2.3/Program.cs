using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj wage w kilogramach oraz wzrost w metrach");
        double waga = double.Parse(Console.ReadLine());
        double wzrost = double.Parse(Console.ReadLine());
        double BMI = waga / (wzrost * wzrost);
        Console.WriteLine(BMI);
        Console.ReadKey();
    }
}
