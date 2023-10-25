using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj średnią ocen: ");
        double sredniaOcen;

        if (double.TryParse(Console.ReadLine(), out sredniaOcen))
        {
            if (sredniaOcen >= 2.0 && sredniaOcen < 4.0)
            {
                Console.WriteLine("Kwota stypendium: 0,00 zł");
            }
            else if (sredniaOcen >= 4.0 && sredniaOcen < 4.8)
            {
                Console.WriteLine("Kwota stypendium: 350,00 zł");
            }
            else if (sredniaOcen >= 4.8 && sredniaOcen <= 5.0)
            {
                Console.WriteLine("Kwota stypendium: 550,00 zł");
            }
            else
            {
                Console.WriteLine("Nieprawidłowa średnia ocen.");
            }
        }
        else
        {
            Console.WriteLine("Nieprawidłowa wartość średniej ocen.");
        }
        Console.ReadLine();
    }
}
