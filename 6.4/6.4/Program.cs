using System;

class LicznikEnergii
{
    private double poczatkowyStanLicznika;
    private double biezacyStanLicznika;

    public LicznikEnergii(double poczatkowyStanLicznika)
    {
        this.poczatkowyStanLicznika = poczatkowyStanLicznika;
        this.biezacyStanLicznika = poczatkowyStanLicznika;
    }

    public void ZarejestrujBiezacyStanLicznika(double biezacyStanLicznika)
    {
        this.biezacyStanLicznika = biezacyStanLicznika;
    }

    public double PobierzPoczatkowyStanLicznika()
    {
        return poczatkowyStanLicznika;
    }
    public double PobierzBiezacyStanLicznika()
    {
        return biezacyStanLicznika;
    }


    public double ObliczZuzycieEnergii()
    {
        return biezacyStanLicznika - poczatkowyStanLicznika;
    }
}

class Program
{
    static void Main()
    {
        LicznikEnergii licznik = new LicznikEnergii(1000);
        licznik.ZarejestrujBiezacyStanLicznika(1200);
        double poczatkowyStan = licznik.PobierzPoczatkowyStanLicznika();
        Console.WriteLine($"Początkowy stan licznika: {poczatkowyStan}");
        double biezacyStan = licznik.PobierzBiezacyStanLicznika();
        Console.WriteLine($"Bieżący stan licznika: {biezacyStan}");
        double zuzycieEnergii = licznik.ObliczZuzycieEnergii();
        Console.WriteLine($"Zużycie energii: {zuzycieEnergii}");
        Console.ReadLine();
    }
}
