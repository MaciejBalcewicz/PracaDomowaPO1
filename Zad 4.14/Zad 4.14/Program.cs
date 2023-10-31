using System;

class Program
{
    static void Main()
    {
        string[] identyfikatory = { "KOMG-2002", "BH-2010", "ABC-2015", "DEF-2000", "XYZ-2005" };
        int obecnyRok = DateTime.Now.Year;

        Console.WriteLine("Liczba lat, jakie upłynęły od zakupu dla poszczególnych środków trwałych:");

        foreach (string identyfikator in identyfikatory)
        {
            int rokZakupu = PobierzRokZakupu(identyfikator);
            if (rokZakupu != -1)
            {
                int lataUplynelo = obecnyRok - rokZakupu;
                Console.WriteLine($"{identyfikator}: {lataUplynelo} lat");
            }
            else
            {
                Console.WriteLine($"{identyfikator}: Błąd w wyodrębnieniu roku zakupu");
            }
        }
    }

    static int PobierzRokZakupu(string identyfikator)
    {
        string[] podzielony = identyfikator.Split('-');
        if (podzielony.Length == 2 && podzielony[1].Length == 4 && int.TryParse(podzielony[1], out int rok))
        {
            return rok;
        }
        return -1; 
    }
}
