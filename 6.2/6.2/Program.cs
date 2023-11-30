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
        Prostokat[] prostokaty = new Prostokat[]
        {
            new Prostokat(5, 10),
            new Prostokat(8, 6),
            new Prostokat(3, 7)
            Console.ReadLine();
        };


        foreach (Prostokat prostokat in prostokaty)
        {
            prostokat.Prezentuj();
            Console.WriteLine(); 
        }
    }
}
