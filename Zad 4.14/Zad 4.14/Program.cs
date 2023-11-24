using System;

class Program
{
    static void Main()
    {
        string[] identyfikatory = { "KOMG-2002", "BH-2010", "XYZ-2015", "ABC-2005", "DEF-2022" };

        int aktualnyRok = DateTime.Now.Year;

        foreach (string identyfikator in identyfikatory)
        {
            int rokZakupu = Int32.Parse(identyfikator.Split('-')[1]);

            int lataOdZakupu = aktualnyRok - rokZakupu;

            Console.WriteLine($"Identyfikator: {identyfikator}, Lata od zakupu: {lataOdZakupu}");
        }
        Console.ReadKey();
    }
}

