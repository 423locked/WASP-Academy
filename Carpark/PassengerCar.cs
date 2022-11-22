namespace Carpark;

public class PassengerCar : Car
{
    public int PassengerAmount { get; set; }

    public Dictionary<string, int> RepairBook { get; set; }

    public PassengerCar(string brand, int power, int productionYear,
        int passengerAmount, Dictionary<string, int> repairBook) : base(brand, power, productionYear)
    {
        PassengerAmount = passengerAmount;
        RepairBook = repairBook;
    }

    public void AddRepairment(string detailName, int appliedYear)
    {
        this.RepairBook.Add(detailName, appliedYear);
    }

    public int GetYearByDetailName(string detailName)
    {
        return this.RepairBook[detailName];
    }

    public void PrintRepairBook()
    {
        foreach (KeyValuePair<string, int> note in this.RepairBook)
            Console.WriteLine($"{note.Value}: {note.Key}");
    }

    public override string ToString()
    {
        return base.ToString() + $", PassengerAmount: { this.PassengerAmount }";
    }
}