using System;

class Program
{
    static void Main()
    {
        int[,] macierzA = { { 1, 2, 3 }, { 4, 5, 6 } };
        int[,] macierzB = { { 7, 8, 9 }, { 10, 11, 12 } };
        int[,] macierzWynikowa = new int[2, 3];

        Console.WriteLine("Macierz A:");
        WyswietlMacierz(macierzA);

        Console.WriteLine("\nMacierz B:");
        WyswietlMacierz(macierzB);

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                macierzWynikowa[i, j] = macierzA[i, j] + macierzB[i, j];
            }
        }

        Console.WriteLine("\nMacierz wynikowa po dodaniu:");
        WyswietlMacierz(macierzWynikowa);
        Console.ReadLine();
    }

    static void WyswietlMacierz(int[,] macierz)
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(macierz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
