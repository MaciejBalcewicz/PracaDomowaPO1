using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadź łańcuch znaków:");
        string lancuch = Console.ReadLine();

        int liczbaWyrazow = PoliczWyrazy(lancuch);

        Console.WriteLine($"Liczba wyrazów w wprowadzonym łańcuchu: {liczbaWyrazow}");
        Console.ReadLine();
    }

    static int PoliczWyrazy(string lancuch)
    {
        
        lancuch = lancuch.Trim();
        while (lancuch.Contains("  "))
        {
            lancuch = lancuch.Replace("  ", " ");
        }


        if (string.IsNullOrWhiteSpace(lancuch))
        {
            return 0;
        }

        
        string[] wyrazy = lancuch.Split(' ');
        return wyrazy.Length;
    }
}
