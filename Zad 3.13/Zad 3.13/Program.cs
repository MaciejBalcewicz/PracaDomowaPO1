using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę naturalną n:");
        int n = int.Parse(Console.ReadLine());

        int suma = 0;
        int znak = 1;

        for (int i = 1; i <= n; i++)
        {
            suma += i * znak;
            znak = -znak; 
        }

        Console.WriteLine("Suma szeregu W({0}) = {1}", n, suma);
        Console.ReadLine();
    }
}

