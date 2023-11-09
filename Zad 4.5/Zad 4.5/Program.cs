using System;

class Program
{
    static void Main()
    {
        int[] tab1 = { 1, 5, 7, 3, 9 }; 
        int n = tab1.Length;
        int[] tab2 = new int[n];

        Console.WriteLine("Tablica źródłowa:");
        WyswietlTablice(tab1);

        for (int i = 0; i < n; i++)
        {
            tab2[(i + 1) % n] = tab1[i];
        }

        Console.WriteLine("\nTablica docelowa po przesunięciu o jedną pozycję:");
        WyswietlTablice(tab2);
        Console.ReadLine();
    }

    static void WyswietlTablice(int[] tablica)
    {
        foreach (var element in tablica)
        {
            Console.Write(element + " ");
        }
    }
}
