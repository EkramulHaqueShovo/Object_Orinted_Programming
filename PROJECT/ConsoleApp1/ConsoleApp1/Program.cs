using System;

class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int YearOfManufacture { get; set; }

    public virtual void StartEngine()
    {
        Console.WriteLine("The engine has started.");
    }
}

class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public override void StartEngine()
    {
        Console.WriteLine("The car's engine has started.");
    }
}

class Motorcycle : Vehicle
{
    public int EngineDisplacement { get; set; }

    public override void StartEngine()
    {
        Console.WriteLine("The motorcycle's engine has started.");
    }
}

class Truck : Vehicle
{
    public int MaximumWeight { get; set; }

    public override void StartEngine()
    {
        Console.WriteLine("The truck's engine has started.");
    }
}

class VehicleDemo
{
    static void Main(string[] args)
    {
        Car car = new Car()
        {
            Brand = "Toyota",
            Model = "Camry",
            YearOfManufacture = 2021,
            NumberOfDoors = 4
        };
        car.StartEngine();

        Motorcycle motorcycle = new Motorcycle()
        {
            Brand = "Honda",
            Model = "CBR1000RR",
            YearOfManufacture = 2022,
            EngineDisplacement = 999
        };
        motorcycle.StartEngine();

        Truck truck = new Truck()
        {
            Brand = "Ford",
            Model = "F-150",
            YearOfManufacture = 2020,
            MaximumWeight = 8000
        };
        truck.StartEngine();
        Console.ReadLine();
    }
}