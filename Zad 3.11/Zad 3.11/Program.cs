using System;

class Program
{
    static void Main(string[] args)
    {
        int suma = 0;
        int liczba = 1;
        int iloscLiczb = 0;

        while (suma <= 100)
        {
            suma += liczba;
            liczba++;
            iloscLiczb++;
        }

        Console.WriteLine("Ilość kolejnych liczb całkowitych, które trzeba dodać, aby suma przekroczyła 100, to: {0}", iloscLiczb);
        Console.ReadLine();
    }
}
