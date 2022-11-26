namespace Carpark;

public class Car
{
    public Car()
    {
        
    }
    
    public Car(string brand, int power, int productionYear)
    {
        Brand = brand;
        Power = power;
        ProductionYear = productionYear;
    }

    public string Brand { get; set; }

    public int Power { get; set; }

    public int ProductionYear { get; set; }

    public override string ToString()
    {
        return $"Brand: {this.Brand}, Power: {this.Power}, ProductionYear: {this.ProductionYear}";
    }
}