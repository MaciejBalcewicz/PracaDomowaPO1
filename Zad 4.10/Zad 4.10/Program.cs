using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj datę w formacie DD-MM-RRRR:");
        string data = Console.ReadLine();

        if (DateTime.TryParseExact(data, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
        {
            string nazwaMiesiaca = PobierzNazweMiesiaca(Date.Month);
            Console.WriteLine($"Podana data to: {Date.ToShortDateString()}");
            Console.WriteLine($"Nazwa miesiąca: {nazwaMiesiaca}");
        }
        else
        {
            Console.WriteLine("Błędny format daty.");
        }
    }

    static string PobierzNazweMiesiaca(int numerMiesiaca)
    {
        return new DateTime(2000, numerMiesiaca, 1).ToString("MMMM");
    }
}
