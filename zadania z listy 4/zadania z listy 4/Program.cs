using System;


class Osoba
{
    protected string imie;
    protected string nazwisko;
    protected int rokUrodzenia;
    private string miejsceZamieszkania;

    public Osoba(string imie, string nazwisko, int rokUrodzenia, string miejsceZamieszkania)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.rokUrodzenia = rokUrodzenia;
        this.miejsceZamieszkania = miejsceZamieszkania;
    }


    public void WypiszInfo()
    {
        Console.WriteLine($"Imię: {imie}, Nazwisko: {nazwisko}, Rok urodzenia: {rokUrodzenia}");
    }


    public int ObliczWiek()
    {
        return DateTime.Now.Year - rokUrodzenia;
    }
}


class Student : Osoba
{
    protected int rok;
    protected string numerGrupy;
    protected string numerAlbumu;


    public Student(string imie, string nazwisko, int rokUrodzenia, string miejsceZamieszkania,
                   int rok, string numerGrupy, string numerAlbumu)
        : base(imie, nazwisko, rokUrodzenia, miejsceZamieszkania)
    {
        this.rok = rok;
        this.numerGrupy = numerGrupy;
        this.numerAlbumu = numerAlbumu;
    }
    
    public new void WypiszInfo()
    {
        base.WypiszInfo();
        Console.WriteLine($"Rok: {rok}, Numer grupy: {numerGrupy}, Numer albumu: {numerAlbumu}");
    }
}


class StudentPierwszegoRoku : Student
{

    public StudentPierwszegoRoku(string imie, string nazwisko, int rokUrodzenia, string miejsceZamieszkania,
                                int rok, string numerGrupy, string numerAlbumu)
        : base(imie, nazwisko, rokUrodzenia, miejsceZamieszkania, rok, numerGrupy, numerAlbumu)
    {

    }
}

class Program
{
    static void Main()
    { 
        Student student = new Student("Jan", "Kowalski", 1990, "Warszawa", 2, "A1", "12345");

        Console.WriteLine($"Wiek studenta: {student.ObliczWiek()} lat");

        // Bląd kompilacji nie można odwoływać się do pola private spoza klasy bazowej.

        // 7. Przypisanie obiektu osoba do studenta i studenta do osoby
        Osoba osoba1 = new Osoba("Anna", "Nowak", 1985, "Kraków");
        Osoba osoba2 = new Osoba("Tomasz", "Kaczor", 1992, "Gdańsk");

        // Bład kompilacji, nie można przypisać obiektu osoba do studenta, ani studenta do osoby.
        // Błąd jest w tym, ze Metoda WypiszInfo() nie jest dostępna, ponieważ osoba2 jest obiektem klasy Osoba.
    }
}

