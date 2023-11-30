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
        Console.WriteLine($"Aktualne współrzędne punktu: ({x}, {y})");
    }
}

class Program
{
    static void Main()
    {
        Punkt punkt = new Punkt(2, 3);

        Console.WriteLine("Początkowe współrzędne punktu:");
        punkt.Wyswietl();
        punkt.Przesun(5, -2);
        Console.WriteLine("Aktualne współrzędne punktu po przesunięciu:");
        punkt.Wyswietl();
    }
}
