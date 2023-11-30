using System;

struct KandydatNaStudia
{
    public string Nazwisko;
    public double PunktyMatematyka;
    public double PunktyInformatyka;
    public double PunktyJezykObcy;

    public double ObliczLacznaLiczbePunktow()
    {
        return 0.6 * PunktyMatematyka + 0.5 * PunktyInformatyka + 0.2 * PunktyJezykObcy;
    }
}

class Program
{
    static void Main()
    {
        KandydatNaStudia[] kandydaci =
        {
            new KandydatNaStudia { Nazwisko = "Kowalski", PunktyMatematyka = 70, PunktyInformatyka = 80, PunktyJezykObcy = 90 },
            new KandydatNaStudia { Nazwisko = "Nowak", PunktyMatematyka = 65, PunktyInformatyka = 75, PunktyJezykObcy = 85 },
            new KandydatNaStudia { Nazwisko = "Wiśniewski", PunktyMatematyka = 80, PunktyInformatyka = 90, PunktyJezykObcy = 70 }
        };

        Console.WriteLine("Lista kandydatów:");

        foreach (var kandydat in kandydaci)
        {
            double lacznaLiczbaPunktow = kandydat.ObliczLacznaLiczbePunktow();
            Console.WriteLine($"{kandydat.Nazwisko}: {lacznaLiczbaPunktow} punktów");
        }
        Console.ReadLine();
    }
}
