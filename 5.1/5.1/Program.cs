using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj temperaturę w stopniach Fahrenheita: ");
        double temperaturaFahrenheit = Convert.ToDouble(Console.ReadLine());

        double temperaturaCelsjusza = KonwersjaFahrenheitNaCelsjusz(temperaturaFahrenheit);

        Console.WriteLine($"{temperaturaFahrenheit} stopni Fahrenheit to {temperaturaCelsjusza} stopni Celsjusza.");
        Console.ReadLine();
    }

    static double KonwersjaFahrenheitNaCelsjusz(double temperaturaFahrenheit)
    {
        double temperaturaCelsjusza = (temperaturaFahrenheit - 32) * 5 / 9;
        return temperaturaCelsjusza;
    }
}
