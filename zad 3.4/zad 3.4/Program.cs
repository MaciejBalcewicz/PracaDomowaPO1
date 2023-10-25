using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj pierwszą liczbę:");
        double liczba1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj znak operacji (+, -, *, /):");
        char operacja = char.Parse(Console.ReadLine());

        Console.WriteLine("Podaj drugą liczbę:");
        double liczba2 = double.Parse(Console.ReadLine());

        double wynik = 0;

        switch (operacja)
        {
            case '+':
                wynik = liczba1 + liczba2;
                break;
            case '-':
                wynik = liczba1 - liczba2;
                break;
            case '*':
                wynik = liczba1 * liczba2;
                break;
            case '/':
                if (liczba2 != 0)
                {
                    wynik = liczba1 / liczba2;
                }
                else
                {
                    Console.WriteLine("Nie można dzielić przez zero.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Nieznany znak operacji.");
                return;
        }

        Console.WriteLine("Wynik operacji: {0}", wynik);
        Console.ReadLine();
    }

}
