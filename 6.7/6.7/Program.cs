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
}

class Odcinek
{
    private Punkt punkt1;
    private Punkt punkt2;


    public Odcinek(Punkt punkt1, Punkt punkt2)
    {
        this.punkt1 = punkt1;
        this.punkt2 = punkt2;
    }


    public double ObliczDlugosc()
    {
        double roznicaX = punkt2.X - punkt1.X;
        double roznicaY = punkt2.Y - punkt1.Y;

        return Math.Sqrt(roznicaX * roznicaX + roznicaY * roznicaY);
    }
}

class Program
{
    static void Main()
    {
        
        Punkt punktA = new Punkt(1, 2);
        Punkt punktB = new Punkt(4, 6);

    
        Odcinek odcinekAB = new Odcinek(punktA, punktB);
        
        double dlugoscOdcinka = odcinekAB.ObliczDlugosc();
        Console.WriteLine($"Długość odcinka AB: {dlugoscOdcinka}");
        Console.ReadLine();
    }
}
