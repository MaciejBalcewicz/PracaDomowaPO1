using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int[] tablica = new int[100];
        int liczbyPierwsze = 0;

        Console.WriteLine("Losowo wygenerowana tablica 100 liczb:");

        for (int i = 0; i < 100; i++)
        {
            tablica[i] = rand.Next(1, 1000);
            Console.Write("{0,8}", tablica[i]);
        }

        for (int i = 0; i < tablica.Length; i++)
        {
            if (CzyLiczbaPierwsza(tablica[i]))
            {
                liczbyPierwsze++;
            }
        }

        Console.WriteLine($"\nIlość liczb pierwszych w tablicy: {liczbyPierwsze}");
        Console.ReadLine();
    }

    static bool CzyLiczbaPierwsza(int liczba)
    {
        if (liczba <= 1)
        {
            return false;
        }

        for (int i = 2; i * i <= liczba; i++)
        {
            if (liczba % i == 0)
            {
                return false;
            }
        }

        return true;
     
    }
   
}

