using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string lancuch = "Kiedy idzie się po miód z balonikiem, to trzeba się starać, żeby pszczoły nie wiedziały, po co się idzie – odpowiedział Puchatek";
        Dictionary<string, int> raport = AnalizujWystapieniaSlow(lancuch);

        Console.WriteLine("Raport o słowach powielonych w tekście:");

        foreach (var kvp in raport)
        {
            if (kvp.Value > 1)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} razy");
            }
        }
        Console.ReadLine();
    }

    static Dictionary<string, int> AnalizujWystapieniaSlow(string lancuch)
    {
        string[] slowa = lancuch.Split(new char[] { ' ', ',', '.', '-', '–', '„', '”', '’', '”' }, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> raport = new Dictionary<string, int>();

        foreach (string slowo in slowa)
        {
            string slowoBezZnakow = slowo.ToLower(); 

            if (raport.ContainsKey(slowoBezZnakow))
            {
                raport[slowoBezZnakow]++;
            }
            else
            {
                raport[slowoBezZnakow] = 1;
            }
        }

        return raport;
    }
}
