using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wprowadź liczbę całkowitą");
        int liczba = int.Parse(Console.ReadLine());

        if (liczba % 2 == 0)
        {
            Console.WriteLine("{0} jest liczbą parzystą", liczba);
        }
        else
        {
            Console.WriteLine("{0} jest liczbą nieparzystą", liczba);
        }

        if (liczba < 0)
        {
            Console.WriteLine("{0} jest liczbą ujemną", liczba);
        }
        else
        {
            Console.WriteLine("{0} nie jest liczbą ujemną", liczba);
        }

        Console.ReadKey();
    }
}
