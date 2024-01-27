namespace lab3;

public enum SongGenre
{
    Unclassified = 0,
    Pop = 0b1,
    Rock = 0b10,
    Blues = 0b100,
    Country = 0b1000,
    Metal = 0b10000,
    Soul = 0b100000,
}

public class Song
{
    public string artist;
    public string title;
    public SongGenre genre;
    public double length;

    public Song(string title, string artist, double length, SongGenre genre)
    {
        this.title = title;
        this.artist = artist;
        this.length = length;
        this.genre = genre;
    }

    public override string ToString()
    {
        return $"{title} by {artist} ({length} minutes)";
    }
}
