namespace Carpark.MusicStore;

public class Audio : Disk
{
    private string _artist;
    private string _recordingStudio;
    private int _songsNumber;

    public override int DiskSize { get => _songsNumber * 8; set => this.DiskSize = value; }

    public Audio(string artist, string recordingStudio, int songsNumber,
        string genre, string name) : base(name, genre)
    {
        _artist = artist;
        _recordingStudio = recordingStudio;
        _songsNumber = songsNumber;
    }

    public override void Burn(params string[] values)
    {
        base.SetBurnCount(base.GetBurnCount() + 1);
        if (values.Length != 3)
            throw new Exception("Burning parameters are artist, recordingStudio, songsNumber");
        _artist = values[0];
        _recordingStudio = values[1];
        _songsNumber = int.Parse(values[2]);
    }

    public override string ToString()
        => $"{base.GetName()} {base.GetGenre()} {this._artist} " +
           $"{this._recordingStudio} {this._songsNumber} {base.GetBurnCount()}";
}