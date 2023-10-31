using System;

class Program
{
    static void Main()
    {
        int[] tab1 = new int[] { 3, -5, 8, -2, 10, 0, 7, -4, 6, -1 }; // Wprowadzenie elementów tablicy tab1
        int[] tab2 = new int[10]; // Nowa tablica tab2

        Console.WriteLine("Elementy tablicy tab1:");

        for (int i = 0; i < tab1.Length; i++)
        {
            Console.Write(tab1[i] + " ");

            if (tab1[i] > 0)
            {
                for (int j = 0; j < tab2.Length; j++)
                {
                    if (tab2[j] == 0) // Znajdź pierwsze wolne miejsce w tablicy tab2
                    {
                        tab2[j] = tab1[i]; // Skopiuj dodatnią wartość z tab1 do tab2
                        break;
                    }
                }
            }
        }

        Console.WriteLine("\nElementy dodatnie z tablicy tab1 skopiowane do tablicy tab2:");

        foreach (int element in tab2)
        {
            if (element > 0)
            {
                Console.Write(element + " ");
            }
        }
        Console.ReadLine();
    }
  
}

