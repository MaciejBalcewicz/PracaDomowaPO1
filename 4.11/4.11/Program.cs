using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadź łańcuch znaków:");
        string lancuch = Console.ReadLine();

        Dictionary<char, int> czestoscZnakow = AnalizujCzestoscZnakow(lancuch);

        Console.WriteLine("Częstość występowania poszczególnych znaków:");

        foreach (var item in czestoscZnakow)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
        Console.ReadLine();
    }

    static Dictionary<char, int> AnalizujCzestoscZnakow(string lancuch)
    {
        Dictionary<char, int> czestoscZnakow = new Dictionary<char, int>();

        foreach (char znak in lancuch)
        {
            if (char.IsLetter(znak)) 
            {
                if (czestoscZnakow.ContainsKey(znak))
                {
                    czestoscZnakow[znak]++;
                }
                else
                {
                    czestoscZnakow[znak] = 1;
                }
            }
        }

        return czestoscZnakow;
    }
}

