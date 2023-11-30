using System;

class Prostokat
{
    private double dlugosc;
    private double szerokosc;
   
    public Prostokat(double dlugosc, double szerokosc)
    {
        this.dlugosc = dlugosc;
        this.szerokosc = szerokosc;
    }
    private double Powierzchnia()
    {
        return dlugosc * szerokosc;
    }

    private double Obwod()
    {
        return 2 * (dlugosc + szerokosc);
    }

    public void Prezentuj()
    {
        Console.WriteLine($"Prostokąt o długości {dlugosc} i szerokości {szerokosc}");
        Console.WriteLine($"Powierzchnia: {Powierzchnia()}");
        Console.WriteLine($"Obwód: {Obwod()}");
    }

    public static double PowierzchniaNajwiekszegoProstokata(Prostokat[] prostokaty)
    {
        double najwiekszaPowierzchnia = 0;

        foreach (Prostokat prostokat in prostokaty)
        {
            double powierzchniaAktualnego = prostokat.Powierzchnia();
            if (powierzchniaAktualnego > najwiekszaPowierzchnia)
            {
                najwiekszaPowierzchnia = powierzchniaAktualnego;
            }
        }

        return najwiekszaPowierzchnia;
    }
}

class Program
{
    static void Main()
    {

        Prostokat[] prostokaty = new Prostokat[]
        {
            new Prostokat(5, 10),
            new Prostokat(8, 6),
            new Prostokat(3, 7)
        };

  
        foreach (Prostokat prostokat in prostokaty)
        {
            prostokat.Prezentuj();
            Console.WriteLine(); 
        }

        double najwiekszaPowierzchnia = Prostokat.PowierzchniaNajwiekszegoProstokata(prostokaty);
        Console.WriteLine($"Największa powierzchnia prostokąta: {najwiekszaPowierzchnia}");
        Console.ReadLine();
    }
}
