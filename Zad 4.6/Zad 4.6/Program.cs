using System;

class Program
{
    static void Main()
    {
        double[,] tablica = new double[5, 5]
        {
            { 1.0, 2.0, 3.0, 4.0, 5.0 },
            { 6.0, 7.0, 8.0, 9.0, 10.0 },
            { 11.0, 12.0, 13.0, 14.0, 15.0 },
            { 16.0, 17.0, 18.0, 19.0, 20.0 },
            { 21.0, 22.0, 23.0, 24.0, 25.0 }
        };

        Console.WriteLine("Elementy tablicy:");
        WyswietlTablice(tablica);

        double suma = 0.0;
        for (int i = 0; i < tablica.GetLength(0); i++)
        {
            suma += tablica[i, i];
        }

        Console.WriteLine($"\nSuma elementów na głównej przekątnej: {suma}");
        Console.ReadLine();
    }

    static void WyswietlTablice(double[,] tablica)
    {
        for (int i = 0; i < tablica.GetLength(0); i++)
        {
            for (int j = 0; j < tablica.GetLength(1); j++)
            {
                Console.Write(tablica[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

