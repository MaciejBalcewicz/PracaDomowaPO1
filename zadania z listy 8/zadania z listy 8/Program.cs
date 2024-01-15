using System;
using System.Collections.Generic;

enum Karta
{
    As = 1,
    Dwa,
    Trzy,
    Cztery,
    Piec,
    Szesc,
    Siedem,
    Osiem,
    Dziewiec,
    Dziesiec,
    Walet,
    Dama,
    Krol
}

class Program
{
    static void Main()
    {
        List<Karta> talia = new List<Karta>();
        talia.AddRange(Enum.GetValues(typeof(Karta)) as Karta[]);

        List<Karta> gracz1 = new List<Karta>();
        List<Karta> gracz2 = new List<Karta>();

        Random random = new Random();
        for (int i = 0; i < 6; i++)
        {
            int index = random.Next(talia.Count);
            gracz1.Add(talia[index]);
            talia.RemoveAt(index);

            index = random.Next(talia.Count);
            gracz2.Add(talia[index]);
            talia.RemoveAt(index);
        }

   
        Console.WriteLine("Karty Gracza 1: " + string.Join(", ", gracz1));
        Console.WriteLine("Karty Gracza 2: " + string.Join(", ", gracz2));
    }
}
