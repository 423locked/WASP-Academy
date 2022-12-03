namespace Carpark.MusicStore;

public interface IStoreItem
{
    public double Price { get; set; }
    
    public void DiscountPrice(int percent);
}