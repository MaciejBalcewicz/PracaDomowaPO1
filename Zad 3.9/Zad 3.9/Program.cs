using System;

class Program
{
    static void PrintLeftBottomTriangle(int rows)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    static void PrintLeftTopTriangle(int rows)
    {
        for (int i = rows; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    static void PrintRightBottomTriangle(int rows)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows - i - 1; j++)
            {
                Console.Write("  ");
            }
            for (int k = 0; k <= i; k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    static void PrintRectangle(int rows, int cols)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Wybierz figurę (a - trójkąt dolny lewy, b - trójkąt górny lewy, c - trójkąt dolny prawy, d - prostokąt): ");
        char choice = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (choice == 'a')
        {
            Console.Write("Podaj liczbę wierszy: ");
            int rows = int.Parse(Console.ReadLine());
            PrintLeftBottomTriangle(rows);
        }
        else if (choice == 'b')
        {
            Console.Write("Podaj liczbę wierszy: ");
            int rows = int.Parse(Console.ReadLine());
            PrintLeftTopTriangle(rows);
        }
        else if (choice == 'c')
        {
            Console.Write("Podaj liczbę wierszy: ");
            int rows = int.Parse(Console.ReadLine());
            PrintRightBottomTriangle(rows);
        }
        else if (choice == 'd')
        {
            Console.Write("Podaj liczbę wierszy: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Podaj liczbę kolumn: ");
            int cols = int.Parse(Console.ReadLine());
            PrintRectangle(rows, cols);
        }
        else
        {
            Console.WriteLine("Nieprawidłowy wybór.");
        }
        Console.ReadLine();
    }
}
