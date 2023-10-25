using System;

class Program
{
    static void Main(string[] args)
    {
        int suma = 0;

        while (true)
        {
            Console.WriteLine("Podaj liczbę całkowitą (wpisz 0, aby zakończyć):");
            int liczba = int.Parse(Console.ReadLine());

            if (liczba == 0)
            {
                break; 
            }

            suma += liczba;
        }

        Console.WriteLine("Suma wprowadzonych liczb: {0}", suma);
        Console.ReadLine();
    }
}

