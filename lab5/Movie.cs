namespace lab5;

class Movie
{
    public int Length { get; }
    public int Year { get; }
    public string Title { get; }
    public GenreEnum Genre { private set; get; }
    public List<string> Cast { get; private set; }

    public Movie(string title, int year, int length)
    {
        Title = title;
        Year = year;
        Length = length;
        Cast = new List<string>();
    }

    public void AddActor(string actor)
    {
        Cast.Add(actor);
    }

    public void SetGenre(GenreEnum genre)
    {
        // @INFO: Bitwise OR operation
        Genre = genre;
    }
}
