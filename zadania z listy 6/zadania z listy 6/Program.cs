using System;

class Test : ICloneable
{
    public int liczba;
    public Test2 poleTestowe;

    public Test()
    {
        poleTestowe = new Test2();
    }

    public object Clone()
    {
        return MemberwiseClone();
    }

    public Test GlebokaKopia()
    {
        Test tempTest = new Test();
        tempTest.liczba = this.liczba;
        tempTest.poleTestowe.slowo = this.poleTestowe.slowo;
        return tempTest;
    }
}

class Test2
{
    public string slowo;
}

class Program
{
    static void Main()
    {
        Test obiekt1 = new Test();
        Test obiekt2, obiekt3;

        obiekt1.liczba = 255;
        obiekt2 = obiekt1;
        obiekt3 = obiekt1.GlebokaKopia();

        obiekt1.liczba = 347;

        Console.WriteLine($"Obiekt 1: {obiekt1.liczba}, {obiekt1.poleTestowe.slowo}");
        Console.WriteLine($"Obiekt 2: {obiekt2.liczba}, {obiekt2.poleTestowe.slowo}");
        Console.WriteLine($"Obiekt 3: {obiekt3.liczba}, {obiekt3.poleTestowe.slowo}");
    }
}
