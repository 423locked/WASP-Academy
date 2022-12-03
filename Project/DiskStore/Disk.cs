namespace Carpark.MusicStore;

public class Disk : IStoreItem
{
    private string _name;
    private string _genre;
    private int _burnCount;
    
    public virtual int DiskSize { get; set; }

    public double Price { get; set; }

    public Disk(string name, string genre)
    {
        _name = name;
        _genre = genre;
        _burnCount = 0;
    }

    public virtual void Burn(params string[] values)
    {
        
    }

    public void DiscountPrice(int percent)
    {
        this.Price = this.Price - percent * this.Price / 100;
    }

    public string GetName() => this._name;
    public string GetGenre() => this._genre;
    public int GetBurnCount() => this._burnCount;
    public void SetBurnCount(int bc) => this._burnCount = bc;
}