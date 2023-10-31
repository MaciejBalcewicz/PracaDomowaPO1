using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę elementów tablicy: ");
        if (!int.TryParse(Console.ReadLine(), out int arrayLength) || arrayLength <= 0)
        {
            Console.WriteLine("Podano nieprawidłową liczbę elementów.");
            return;
        }

        int[] tablica = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write($"Podaj wartość elementu {i + 1}: ");
            if (!int.TryParse(Console.ReadLine(), out tablica[i]))
            {
                Console.WriteLine("Podano nieprawidłową wartość. Wprowadź liczbę całkowitą.");
                i--; // Powtórzenie wprowadzania tej samej wartości
            }
        }

        Console.WriteLine("Wypełniona tablica:");
        foreach (int element in tablica)
        {
            Console.Write(element + " ");
        }
    }
}

