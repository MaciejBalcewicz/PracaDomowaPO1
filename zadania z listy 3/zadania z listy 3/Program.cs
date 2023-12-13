using System;

class Obliczenia
{
    private double wynik;

    public void Dodawanie(double a, double b)
    {
        wynik = a + b;
    }

    public void Odejmowanie(double a, double b)
    {
        wynik = a - b;
    }

    public void Mnozenie(double a, double b)
    {
        wynik = a * b;
    }

    public void Dzielenie(double a, double b)
    {
        if (b != 0)
        {
            wynik = a / b;
        }
        else
        {
            Console.WriteLine("Nie można dzielić przez zero.");
        }
    }

    public void Potegowanie(double podstawa, double wykladnik)
    {
        wynik = Math.Pow(podstawa, wykladnik);
    }

    public void Pierwiastkowanie(double liczba, double stopien)
    {
        if (liczba >= 0)
        {
            wynik = Math.Pow(liczba, 1.0 / stopien);
        }
        else
        {
            Console.WriteLine("Nie można pierwiastkować liczby ujemnej.");
        }
    }

    public double PobierzWynik()
    {
        return wynik;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Obliczenia kalkulator = new Obliczenia();

            Console.Write("Podaj pierwszą liczbę: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj drugą liczbę: ");
            double b = Convert.ToDouble(Console.ReadLine());

            kalkulator.Dodawanie(a, b);
            Console.WriteLine($"Wynik dodawania: {kalkulator.PobierzWynik()}");

            kalkulator.Odejmowanie(a, b);
            Console.WriteLine($"Wynik odejmowania: {kalkulator.PobierzWynik()}");

            kalkulator.Mnozenie(a, b);
            Console.WriteLine($"Wynik mnożenia: {kalkulator.PobierzWynik()}");

            kalkulator.Dzielenie(a, b);
            Console.WriteLine($"Wynik dzielenia: {kalkulator.PobierzWynik()}");

            kalkulator.Potegowanie(a, b);
            Console.WriteLine($"Wynik potęgowania: {kalkulator.PobierzWynik()}");

            kalkulator.Pierwiastkowanie(a, b);
            Console.WriteLine($"Wynik pierwiastkowania: {kalkulator.PobierzWynik()}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Błąd formatu danych. Podaj poprawne liczby.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Wystąpił błąd: {ex.Message}");
        }
        finally
        {
            Console.ReadLine();
        }
    }
}
