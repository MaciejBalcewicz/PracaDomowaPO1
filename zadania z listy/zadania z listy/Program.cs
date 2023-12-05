using System;

class Program
{
    static void Main()
    {
        Car car1 = new Car();
        car1.Marka = "Toyota";
        car1.RokProdukcji = 2022;

        car1.WyswietlInformacje();

        double dlugoscTrasy = 100.0;
        double cenaPaliwa = 4.5;

        car1.ObliczISpaldaj(dlugoscTrasy);

        double kosztPrzejazdu = car1.ObliczKosztPrzejazdu(dlugoscTrasy, cenaPaliwa);
        Console.WriteLine($"Koszt przejazdu dla trasy o długości {dlugoscTrasy} km: {kosztPrzejazdu} zł");

        Console.ReadLine();
    }
}

public class Car
{
    private string marka;
    private int rokProdukcji;

    public Car()
    {
        marka = "";
        rokProdukcji = 0;
    }

    public string Marka
    {
        get { return marka; }
        set { marka = value; }
    }

    public int RokProdukcji
    {
        get { return rokProdukcji; }
        set { rokProdukcji = value; }
    }

    private double ObliczSpalanie(double dlugoscTrasy)
    {
        return 10.0 * dlugoscTrasy; 
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine($"Marka: {marka}, Rok produkcji: {rokProdukcji}");
    }

    public void ObliczISpaldaj(double dlugoscTrasy)
    {
        double spalanie = ObliczSpalanie(dlugoscTrasy);
        Console.WriteLine($"Spalanie dla trasy o długości {dlugoscTrasy} km: {spalanie} L");
    }

    public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
    {
        double spalanie = ObliczSpalanie(dlugoscTrasy);
        return spalanie * cenaPaliwa;
    }
}

