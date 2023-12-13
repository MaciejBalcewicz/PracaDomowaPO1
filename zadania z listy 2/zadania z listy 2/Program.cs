using System;

class Program
{
    static void Main()
    {
        try
        {
            int liczba3 = 0;
            int liczba1 = 30 / liczba3;
            Console.WriteLine("Nie zostanie wyświetlone, bo dzielimy przez 0");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine($"Typ wyjątku: {e.GetType()}");
            Console.WriteLine($"StackTrace: {e.StackTrace}");
        }
        finally
        {
            Console.WriteLine("FINALLY");
        }

        try
        {
            int[] table = new int[2];
            table[25] = 2;
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine($"Wyjątek IndexOutOfRangeException: {e.Message}");
        }
        catch
        {
            Console.WriteLine("Inny wyjątek");
        }

        try
        {
            throw new IndexOutOfRangeException();
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine($"Przechwycono wyjątek: {e.Message}");
        }
        Console.ReadLine();
    }
   
}

class Car
{
    private double pojemnoscSilnika;
    private string marka;

    private Car()
    {
        pojemnoscSilnika = 0.0;
        marka = "";
    }

    public Car(double pojemnoscSilnika, string marka)
    {
        this.pojemnoscSilnika = pojemnoscSilnika;
        this.marka = marka;
    }

    public static Car Create()
    {
        return new Car();
    }

    ~Car()
    {
        Console.WriteLine("Zwalniam pamiec");
    }

    public static int iloscKol;

    static Car()
    {
        iloscKol = 4;
    }
}

