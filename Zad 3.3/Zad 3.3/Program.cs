using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj pierwszą liczbę:");
        int pierwszaLiczba = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj drugą liczbę:");
        int drugaLiczba = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj trzecią liczbę:");
        int trzeciaLiczba = int.Parse(Console.ReadLine());

        int najwieksza = Math.Max(Math.Max(pierwszaLiczba, drugaLiczba), trzeciaLiczba);

        Console.WriteLine("Największa liczba to: {0}", najwieksza);
        Console.ReadLine();
    }
}
