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
    
    public static void Test2_2()
    {
        Homework.Hometasks.Task2_2(5, 12);
    }
    
    public static void Test2_3_4()
    {
        Homework.Hometasks.Task2_3(1, 2, 4, 8);
        Homework.Hometasks.Task2_4(2251816993685505);
    }

    public static void Test1_3()
    {
        Homework.Hometasks.Task1_3(0, 0, 0, 4, 4, 4);
        Homework.Hometasks.Task1_3(4, 0, 0, 4, 4, 4);
        Homework.Hometasks.Task1_3(0, 0, 4, 0, 0, 4);
        Homework.Hometasks.Task1_3(0, 0, 4, 0, 4, 4);
    }

    public static void Test3_1()
    {
        int[] a = {1, 1, 1, 1};
        int p = 2;
        Console.WriteLine(Homework.Hometasks.Task3_1(p, a));
    }
    
    public static void Test3_2()
    {
        int[] a = {5, 6, 0, -1, 3, 9, 4, 4, 4, 8};
        Console.WriteLine(Homework.Hometasks.Task3_2(2, a));
    }

    public static void Test3_3()
    {
        int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        string query = "2:10:-2";
        foreach (var el in Homework.Hometasks.Task3_3(a, query))
            Console.WriteLine($"{el} ");
    }
}