using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> tabliczkaMnozenia = new Dictionary<int, string>
        {
            {1, "I"}, {2, "II"}, {3, "III"}
        };

        foreach (var kvp in tabliczkaMnozenia)
        {
            Console.WriteLine($"Liczba: {kvp.Key}, Rzymski zapis: {kvp.Value}");
        }
        Console.ReadLine();
    }
}
