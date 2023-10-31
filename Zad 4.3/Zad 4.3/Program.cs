using System;

class Program
{
    static void Main()
    {
        int n;

        Console.Write("Podaj liczbę elementów w tablicy: ");
        if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Podano nieprawidłową liczbę elementów lub liczbę mniejszą niż 1.");
            return;
        }

        int[] tablica = new int[n];

        for (int i = 0; i < n; i++)
        {
            bool validInput = false;
            do
            {
                Console.Write($"Podaj wartość elementu {i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out tablica[i]))
                {
                    Console.WriteLine("Podano nieprawidłową wartość. Wprowadź liczbę całkowitą.");
                }
                else
                {
                    validInput = true;
                }
            } while (!validInput);
        }

        int maxWartosc = int.MinValue;
        int minWartosc = int.MaxValue;
        int maxPozycja = 0;
        int minPozycja = 0;
        int suma = 0;
        int dodatnie = 0;

        for (int i = 0; i < n; i++)
        {
            if (tablica[i] > maxWartosc)
            {
                maxWartosc = tablica[i];
                maxPozycja = i;
            }
            if (tablica[i] < minWartosc)
            {
                minWartosc = tablica[i];
                minPozycja = i;
            }
            suma += tablica[i];
            if (tablica[i] > 0)
            {
                dodatnie++;
            }
        }

        double srednia = (double)suma / n;

        Console.WriteLine($"Wartość największego elementu: {maxWartosc}, pozycja: {maxPozycja}");
        Console.WriteLine($"Wartość najmniejszego elementu: {minWartosc}, pozycja: {minPozycja}");
        Console.WriteLine($"Średnia wartości wszystkich elementów: {srednia}");
        Console.WriteLine($"Liczba wartości dodatnich w tablicy: {dodatnie}");
        Console.ReadLine();
    }
}

