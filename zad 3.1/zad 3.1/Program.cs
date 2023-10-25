using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wprowadź rok:");
        int rok = int.Parse(Console.ReadLine());

        bool jestPrzestepny = (rok % 4 == 0) && (rok % 100 != 0 || rok % 400 == 0);

        if (jestPrzestepny)
        {
            Console.WriteLine("{0} to rok przestępny.", rok);
        }
        else
        {
            Console.WriteLine("{0} to nie jest rok przestępny.", rok);

        }
        Console.ReadLine();
    }
}


