using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] monety = { 1, 2, 5 };
        int suma = 10;
        List<int> kombinacja = new List<int>();

        WypiszKombinacje(monety, suma, kombinacja, 0);
    }

    static void WypiszKombinacje(int[] monety, int suma, List<int> kombinacja, int index)
    {
        if (suma == 0)
        {
            Console.WriteLine(string.Join(" + ", kombinacja));
            return;
        }

        if (suma < 0 || index == monety.Length)
        {
            return;
        }

        kombinacja.Add(monety[index]);
        WypiszKombinacje(monety, suma - monety[index], kombinacja, index);

        kombinacja.RemoveAt(kombinacja.Count - 1);
        WypiszKombinacje(monety, suma, kombinacja, index + 1);
        Console.ReadLine();
    }
}
