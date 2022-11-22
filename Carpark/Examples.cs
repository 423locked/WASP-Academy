namespace Carpark;

public static class Examples
{
    public static void TestCarpark()
    {
        Dictionary<string, int> repairs = new Dictionary<string, int>()
        {
            { "Repairment 1", 2015 },
            { "Wheel replacement", 2022 }
        };
            
        Dictionary<string, int> currentCargo = new Dictionary<string, int>()
        {
            { "Apples", 300 },
            { "Bananas", 220 },
            { "Dragonfruits", 180 }
        };
            
        List<Car> vehicles = new List<Car>()
        {
            new Car("BMW", 340, 2016),
            new PassengerCar("Opel", 120, 2012, 3, repairs),
            new Truck("MAN", 1200, 2003, 50000,
                "Mike", "Fleming", currentCargo)
        };

        Carpark carpark = new Carpark("Autopark", vehicles);
        carpark.PrintVehicles();
    }
}