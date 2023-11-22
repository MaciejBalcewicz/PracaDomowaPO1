using System;

namespace _5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = { 1, 2, 3, 4, 5 };
            int[] wynikA = mnozenieA(tablica, 2);

            Console.WriteLine("Wynik metody mnozenieA:");
            napisztablice(wynikA);

            mnozenieB(tablica, 2);

            Console.WriteLine("Tablica po wywołaniu metody mnozenieB:");
            napisztablice(tablica);

            Console.ReadLine();

            string[] napis = { "odholuj", "mnie", "ziutek" };
            przeciazonemnozenie(napis, 2);

            Console.WriteLine("Tablica po wywołaniu przeciazonemnozenie:");
            napisztablice(napis);

            Console.ReadLine();
        }

        static int[] mnozenieA(int[] tab, int mnoznik)
        {
            int[] wynik = new int[tab.Length];
            for (int i = 0; i < tab.Length; i++)
            {
                wynik[i] = tab[i] * mnoznik;
            }
            return wynik;
        }

        static void mnozenieB(int[] tab, int mnoznik)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = tab[i] * mnoznik;
            }
        }

        static void przeciazonemnozenie(string[] tab, int mnoznik)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                string powielonyNapis = "";
                for (int j = 0; j < mnoznik; j++)
                {
                    powielonyNapis += tab[i];
                }
                tab[i] = powielonyNapis;
            }
        }

        static void napisztablice<T>(T[] array)
        {
            Console.WriteLine("[" + string.Join(", ", array) + "]");
        }
    }
}
