using System;

class Vehicle
{
}

class Car : Vehicle, IRideable
{
    public void Ride()
    {
        Console.WriteLine("Jadę samochodem");
    }
}

class Bicycle : Vehicle, IRideable
{
    public void Ride()
    {
        Console.WriteLine("Jadę rowerem");
    }
}

interface IRideable
{
    void Ride();
}

class Program
{
    static void Main()
    {
        Car car1 = new Car();
        Bicycle bicycle1 = new Bicycle();

        car1.Ride();
        bicycle1.Ride();
    }
}
