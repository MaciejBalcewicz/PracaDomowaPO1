using System;

class Program
{
    static void Main()
    {
        int[] tab1 = new int[] { 3, -5, 8, -2, 10, 0, 7, -4, 6, -1 }; 
        int[] tab2 = new int[10]; 

        Console.WriteLine("Elementy tablicy tab1:");

        for (int i = 0; i < tab1.Length; i++)
        {
            Console.Write(tab1[i] + " ");

            if (tab1[i] > 0)
            {
                for (int j = 0; j < tab2.Length; j++)
                {
                    if (tab2[j] == 0) 
                    {
                        tab2[j] = tab1[i];
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

