using System;

class Program
{
    static void Main()
    {
        string tekst = "W parę godzin później, gdy noc zbierała się do odejścia,\n" +
         "Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
         "To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
         "co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
         "wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł.";

        Console.WriteLine("Zawartość tekstu:");
        Console.WriteLine(tekst);

        int liczbaWierszy = PodajLiczbeWierszy(tekst);
        Console.WriteLine($"\nLiczba wierszy: {liczbaWierszy}");

        int[] liczbaZnakowWWierszach = PodajLiczbeZnakowWWierszach(tekst);
        for (int i = 0; i < liczbaZnakowWWierszach.Length; i++)
        {
            Console.WriteLine($"Liczba znaków w wierszu {i + 1}: {liczbaZnakowWWierszach[i]}");
        }
        Console.ReadLine();
    }

    static int PodajLiczbeWierszy(string tekst)
    {
        int liczbaNowychLinii = tekst.Split('\n').Length;
        return liczbaNowychLinii;
    }

    static int[] PodajLiczbeZnakowWWierszach(string tekst)
    {
        string[] wiersze = tekst.Split('\n');
        int[] liczbaZnakowWWierszach = new int[wiersze.Length];

        for (int i = 0; i < wiersze.Length; i++)
        {
            liczbaZnakowWWierszach[i] = wiersze[i].Length;
        }

        return liczbaZnakowWWierszach;
    }
}
