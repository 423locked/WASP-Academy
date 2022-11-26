namespace Carpark;

public class Truck : Car
{
    public Truck(string brand, int power, int productionYear,
        int maxWeight, string driverFirstName, string driverLastName,
        Dictionary<string, int> currentCargo) : base(brand, power, productionYear)
    {
        MaxWeight = maxWeight;
        DriverFirstName = driverFirstName;
        DriverLastName = driverLastName;
        CurrentCargo = currentCargo;
    }
    
    public int MaxWeight { get; set; }

    public string DriverFirstName { get; set; }

    public string DriverLastName { get; set; }
    
    public Dictionary<string, int> CurrentCargo { get; set; }

    public void SwitchDriver(string firstName, string lastName)
    {
        this.DriverFirstName = firstName;
        this.DriverLastName = lastName;
    }

    public void AddCargo(string cargoName, int weight)
    {
        this.CurrentCargo.Add(cargoName, weight);
    }

    public void RemoveCargoByName(string cargoName)
    {
        this.CurrentCargo.Remove(cargoName);
    }
    
    public void PrintRepairBook()
    {
        foreach (KeyValuePair<string, int> cargo in this.CurrentCargo)
            Console.WriteLine($"{cargo.Key}: {cargo.Value}");
    }

    public override string ToString()
    {
        return base.ToString() + $", MaxWeight: {this.MaxWeight}, " +
               $"DriverFirstName: {this.DriverFirstName}, DriverLastName: {this.DriverLastName}";
    }
}