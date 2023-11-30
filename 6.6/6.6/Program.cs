using System;

class Punkt
{
    private double x;
    private double y;

    public Punkt(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public double X
    {
        get { return x; }
        set { x = value; }
    }

    public double Y
    {
        get { return y; }
        set { y = value; }
    }

    public void Przesun(double przesuniecieX, double przesuniecieY)
    {
        x += przesuniecieX;
        y += przesuniecieY;
    }

    public void Wyswietl()
    {
        Console.WriteLine($"({x}, {y})");
    }


    public static bool CzyPunktyNaProstej(Punkt punkt1, Punkt punkt2, Punkt punkt3)
    {

        return (punkt2.Y - punkt1.Y) * (punkt3.X - punkt2.X) == (punkt3.Y - punkt2.Y) * (punkt2.X - punkt1.X);
    }
}

class Program
{
    static void Main()
    {
       
        Punkt punkt1 = new Punkt(1, 1);
        Punkt punkt2 = new Punkt(2, 2);
        Punkt punkt3 = new Punkt(3, 3);

  
        Console.WriteLine("Współrzędne punktu 1:");
        punkt1.Wyswietl();
        Console.WriteLine("Współrzędne punktu 2:");
        punkt2.Wyswietl();
        Console.WriteLine("Współrzędne punktu 3:");
        punkt3.Wyswietl();

        bool czyNaProstej = Punkt.CzyPunktyNaProstej(punkt1, punkt2, punkt3);

        if (czyNaProstej)
            Console.WriteLine("Punkty leżą na jednej prostej.");
        else
            Console.WriteLine("Punkty nie leżą na jednej prostej.");
        Console.ReadLine();
    }
}
