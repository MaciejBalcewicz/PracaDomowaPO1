using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Kalkulator:");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");
            Console.WriteLine("5. Wyjście");

            Console.Write("Wybierz operację (1-5): ");
            string choice = Console.ReadLine();

            if (choice == "5")
            {
                break;
            }

            try
            {
                Console.Write("Podaj pierwszą liczbę: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Podaj drugą liczbę: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (choice)
                {
                    case "1":
                        result = num1 + num2;
                        break;
                    case "2":
                        result = num1 - num2;
                        break;
                    case "3":
                        result = num1 * num2;
                        break;
                    case "4":
                        if (num2 == 0)
                        {
                            throw new DivideByZeroException("Nie można dzielić przez zero.");
                        }
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór operacji.");
                        continue;
                }

                Console.WriteLine($"Wynik: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Błąd: Wprowadzono nieprawidłową liczbę.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }
        }
    }
}
