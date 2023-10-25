using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę n:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Liczby doskonałe w przedziale od 1 do {0}:", n);

        for (int liczba = 1; liczba <= n; liczba++)
        {
            if (CzyDoskonala(liczba))
            {
                Console.WriteLine(liczba);
            }
        }
    }

    static bool CzyDoskonala(int liczba)
    {
        int sumaPodzielnikow = 0;

        for (int i = 1; i < liczba; i++)
        {
            if (liczba % i == 0)
            {
                sumaPodzielnikow += i;
            }
        }

        return sumaPodzielnikow == liczba;
    }
}

