using System;
using System.IO;

class Konto
{
    private string numerKonta;
    private decimal saldo;

    public Konto(string numerKonta, decimal saldoPoczatkowe)
    {
        this.numerKonta = numerKonta;
        this.saldo = saldoPoczatkowe;
    }

    public void Wplata(decimal kwota)
    {
        saldo += kwota;
        Console.WriteLine($"Wpłata na konto {numerKonta}: {kwota} PLN");
    }

    public void Wyplata(decimal kwota)
    {
        if (kwota <= saldo)
        {
            saldo -= kwota;
            Console.WriteLine($"Wypłata z konta {numerKonta}: {kwota} PLN");
        }
        else
        {
            Console.WriteLine($"Niewystarczające saldo na koncie {numerKonta}");
        }
    }

    public void Przelew(Konto odbiorca, decimal kwota)
    {
        if (kwota <= saldo)
        {
            saldo -= kwota;
            odbiorca.Wplata(kwota);
            Console.WriteLine($"Przelew z konta {numerKonta} na konto {odbiorca.numerKonta}: {kwota} PLN");
        }
        else
        {
            Console.WriteLine($"Niewystarczające saldo na koncie {numerKonta} do wykonania przelewu");
        }
    }

    public void WyswietlStanKonta()
    {
        Console.WriteLine($"Stan konta {numerKonta}: {saldo} PLN");
    }

    public void ZapiszDoPliku(string nazwaPliku)
    {
        using (StreamWriter writer = new StreamWriter(nazwaPliku, true))
        {
            writer.WriteLine($"Numer konta: {numerKonta}, Saldo: {saldo} PLN");
        }
    }
}

class KontoPrywatne : Konto
{
    public KontoPrywatne(string numerKonta, decimal saldoPoczatkowe) : base(numerKonta, saldoPoczatkowe)
    {
    }

    public void PrzelewWynagrodzenia(decimal kwota)
    {
        Wplata(kwota);
        Console.WriteLine($"Przelew wynagrodzenia na konto {numerKonta}: {kwota} PLN");
    }

    public void Otrzymanie500Plus()
    {
        Wplata(500);
        Console.WriteLine($"Otrzymano 500+ na konto {numerKonta}");
    }
}

class KontoFirmowe : Konto
{
    public KontoFirmowe(string numerKonta, decimal saldoPoczatkowe) : base(numerKonta, saldoPoczatkowe)
    {
    }

    public void PrzelewDoZUS(decimal kwota)
    {
        if (kwota <= saldo)
        {
            saldo -= kwota;
            Console.WriteLine($"Przelew do ZUS z konta {numerKonta}: {kwota} PLN");
        }
        else
        {
            Console.WriteLine($"Niewystarczające saldo na koncie {numerKonta} do wykonania przelewu do ZUS");
        }
    }

    public void PrzelewDoUS(decimal kwota)
    {
        if (kwota <= saldo)
        {
            saldo -= kwota;
            Console.WriteLine($"Przelew do US z konta {numerKonta}: {kwota} PLN");
        }
        else
        {
            Console.WriteLine($"Niewystarczające saldo na koncie {numerKonta} do wykonania przelewu do US");
        }
    }
}

class Program
{
    static void Main()
    {
        string nazwaPliku = "historia_konta.txt";

        if (!File.Exists(nazwaPliku))
        {
            Konto konto1 = new Konto("12345678901234567890", 1000);
            KontoPrywatne kontoPrywatne = new KontoPrywatne("98765432109876543210", 2000);
            KontoFirmowe kontoFirmowe = new KontoFirmowe("11112222333344445555", 3000);

            konto1.Wplata(500);
            kontoPrywatne.PrzelewWynagrodzenia(1000);
            kontoFirmowe.PrzelewDoZUS(500);

            konto1.WyswietlStanKonta();
            kontoPrywatne.WyswietlStanKonta();
            kontoFirmowe.WyswietlStanKonta();

            konto1.ZapiszDoPliku(nazwaPliku);
            kontoPrywatne.ZapiszDoPliku(nazwaPliku);
            kontoFirmowe.ZapiszDoPliku(nazwaPliku);
        }
        else
        {
            Console.WriteLine("Historia konta istnieje. Wczytuję zapisane dane.");

            using (StreamReader reader = new StreamReader(nazwaPliku))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        Console.ReadLine();
    }

}
