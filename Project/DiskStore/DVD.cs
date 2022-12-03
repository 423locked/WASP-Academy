namespace Carpark.MusicStore;

public class DVD : Disk
{
    private string _producer;
    private string _filmCompany;
    private int _minutesCount;

    public DVD(string producer, string filmCompany, int minutesCount,
        string name, string genre) : base(name, genre)
    {
        _producer = producer;
        _filmCompany = filmCompany;
        _minutesCount = minutesCount;
    }

    public override int DiskSize
    {
        get => (this._minutesCount / 64) * 2;
        set => this.DiskSize = value;
    }

    public override void Burn(params string[] values)
    {
        base.SetBurnCount(base.GetBurnCount() + 1);
        if (values.Length != 3)
            throw new Exception("Burning parameters are producer, filmCompany, minutesCount");
        _producer = values[0];
        _filmCompany = values[1];
        _minutesCount = int.Parse(values[2]);
    }

    public override string ToString()
        => $"{base.GetName()} {base.GetGenre()} {this._producer} " +
           $"{this._filmCompany} {this._minutesCount} {base.GetBurnCount()}";
}