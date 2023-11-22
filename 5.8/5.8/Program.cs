using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(sumacyfr(x));
            Console.ReadLine();
        }
        static int sumacyfr(int x)
        {
            int wynik = 0;
            int licznik = 0;
            int pdousuniecia = 1;
            int y = x;
            for (int i = x; i > 0; i = i / 10)
            {
                y = y - y / 10;
                licznik++;
            }
            for (int j = 1; j < licznik; j++)
            { pdousuniecia = pdousuniecia * 10; }
            
            for (int i=licznik;i>0;i--)
            {
                wynik += (x - x % pdousuniecia) / pdousuniecia;
                x = x % pdousuniecia;
                pdousuniecia = pdousuniecia/10;


            }
            return wynik;

        }
     
        }

    }

