using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = { 1, 2, 3, 4, 5 };
            int[] wynikA = mnozenieA(tablica, 2);
            for (int i = 0; i < tablica.Length; i++)
            { Console.WriteLine(wynikA[i]); }
      
            mnozenieB(tablica, 2);
            for (int i = 0; i < tablica.Length; i++)
            { Console.WriteLine(tablica[i]); }
            Console.ReadLine();
        }
        static int[] mnozenieA(int[] tab, int mnoznik)
        {
            int[] wynik = new int[tab.Length];
            for (int i = 0; i < tab.Length; i++)
            { wynik[i] = tab[i] * mnoznik; }
            return wynik;
        }
        static int[] mnozenieB(int[] tab, int mnoznik)
        {
            for (int i = 0; i < tab.Length; i++)
            { tab[i] = tab[i] * mnoznik; }
            return tab;
        }
    }
}
    

