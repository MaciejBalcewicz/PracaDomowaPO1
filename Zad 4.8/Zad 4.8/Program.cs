using System;

class Program
{
    static void Main()
    {
        string[,] dniTygodnia;
        dniTygodnia = new string[7, 3]; // zmieniony rozmiar tablicy na 7 dni tygodnia

        dniTygodnia[0, 0] = "poniedziałek";
        dniTygodnia[1, 0] = "wtorek";
        dniTygodnia[2, 0] = "środa";
        dniTygodnia[3, 0] = "czwartek";
        dniTygodnia[4, 0] = "piątek";
        dniTygodnia[5, 0] = "sobota";
        dniTygodnia[6, 0] = "niedziela";

        dniTygodnia[0, 1] = "monday";
        dniTygodnia[1, 1] = "tuesday";
        dniTygodnia[2, 1] = "wednesday";
        dniTygodnia[3, 1] = "thursday";
        dniTygodnia[4, 1] = "friday";
        dniTygodnia[5, 1] = "saturday";
        dniTygodnia[6, 1] = "sunday";

        dniTygodnia[0, 2] = "montag";
        dniTygodnia[1, 2] = "dienstag";
        dniTygodnia[2, 2] = "mittwoch";
        dniTygodnia[3, 2] = "donnerstag";
        dniTygodnia[4, 2] = "freitag";
        dniTygodnia[5, 2] = "samstag";
        dniTygodnia[6, 2] = "sonntag";

        // Wyświetlenie tablicy dniTygodnia
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(dniTygodnia[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}

