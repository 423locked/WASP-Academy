using Carpark;
using Carpark = Carpark.Carpark;

namespace CarparkTests;

public class Tests
{
    [Test]
    public void TestCarCreation()
    {
        Car car = new Car("BMW", 340, 2016);
        string expected = $"Brand: BMW, Power: 340, ProductionYear: 2016";
        Assert.That(car.ToString(), Is.EqualTo(expected));
    }

    [Test]
    public void TestPassengerCarCreation()
    {
        Dictionary<string, int> repairs = new Dictionary<string, int>()
        {
            { "Repairment 1", 2015 },
            { "Wheel replacement", 2022 }
        };
        PassengerCar passengerCar = new PassengerCar("Opel", 120, 2012, 3, repairs);
        string expected = $"Brand: Opel, Power: 120, ProductionYear: 2012, PassengerAmount: 3";
        Assert.That(passengerCar.ToString(), Is.EqualTo(expected));
    }

    [Test]
    public void TestTruckCreation()
    {
        Dictionary<string, int> currentCargo = new Dictionary<string, int>()
        {
            { "Apples", 300 },
            { "Bananas", 220 },
            { "Dragonfruits", 180 }
        };
        Truck truck = new Truck("MAN", 1200, 2003, 50000,
            "Mike", "Fleming", currentCargo);
        string expected = $"Brand: MAN, Power: 1200, ProductionYear: 2003, " +
                          $"MaxWeight: 50000, DriverFirstName: Mike, DriverLastName: Fleming";
        Assert.That(truck.ToString(), Is.EqualTo(expected));
    }

    [Test]
    public void TestTruckMethods()
    {
        Dictionary<string, int> currentCargo = new Dictionary<string, int>()
        {
            { "Apples", 300 },
            { "Bananas", 220 },
            { "Dragonfruits", 180 }
        };
        Truck truck = new Truck("MAN", 1200, 2003, 50000,
            "Mike", "Fleming", currentCargo);
        
        truck.SwitchDriver("Alex", "Corey");
        truck.AddCargo("Oranges", 500);
        truck.RemoveCargoByName("Bananas");
        int expected = 3;
        Assert.That(truck.CurrentCargo.Count(), Is.EqualTo(expected));
    }

    [Test]
    public void TestPassengerCarMethods()
    {
        Dictionary<string, int> repairs = new Dictionary<string, int>()
        {
            { "Repairment 1", 2015 },
            { "Wheel replacement", 2022 }
        };
        PassengerCar passengerCar = new PassengerCar("Opel", 120, 2012, 3, repairs);
        passengerCar.AddRepairment("Windshield fixes", 2022);
        int expected = 2022;
        Assert.That(passengerCar.GetYearByDetailName("Wheel replacement"), Is.EqualTo(expected));
    }
}