using System.Text;

namespace Carpark.MusicStore;

public class Store
{
    private string _storeName;
    private string _address;
    public List<Audio> Audios { get; set; }
    public List<DVD> DVDs { get; set; }

    public Store(string storeName, string address)
    {
        _storeName = storeName;
        _address = address;
        this.Audios = new List<Audio> { };
        this.DVDs = new List<DVD> { };
    }
    
    public static Store operator +(Store store, Audio audio)
    {
        store.Audios.Add(audio);
        return store;
    }

    public static Store operator +(Store store, DVD dvd)
    {
        store.DVDs.Add(dvd);
        return store;
    }
    
    public static Store operator -(Store store, Audio audio)
    {
        store.Audios.Remove(audio);
        return store;
    }

    public static Store operator -(Store store, DVD dvd)
    {
        store.DVDs.Remove(dvd);
        return store;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"Store: {this._storeName}, Address: {this._address}\n");
        
        sb.Append("\nAudios:\n");
        foreach (var audio in this.Audios)
            sb.Append(audio.ToString() + "\n");
        
        sb.Append("\nDVDs:\n");
        foreach (var dvd in this.DVDs)
            sb.Append(dvd.ToString() + "\n");

        return sb.ToString();
    }
}