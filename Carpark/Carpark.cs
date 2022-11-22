namespace Carpark;

public class Carpark
{
    public Carpark(string name, List<Car> vehicles)
    {
        Name = name;
        Vehicles = vehicles;
    }

    public string Name { get; set; }

    public List<Car> Vehicles { get; set; }

    public void PrintVehicles()
    {
        foreach (Car car in Vehicles)
            Console.WriteLine(car.ToString());
    }
}