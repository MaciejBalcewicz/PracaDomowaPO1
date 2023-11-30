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
}

class Program
{
    static void Main()
    {
        Prostokat mojProstokat = new Prostokat(5, 10);

        mojProstokat.Prezentuj();
        Console.ReadLine();

    }
}
