namespace lab5;

class Theatre
{
    private List<Show> shows;

    public string Name { get; }

    public Theatre(string name)
    {
        Name = name;
        shows = new List<Show>();
    }

    public void AddShow(Show show)
    {
        shows.Add(show);
    }

    public void PrintTheatre(string day = "")
    {
        Console.WriteLine("\n");
        Console.WriteLine(Name);
        Console.WriteLine(day != "" ? day : "All Shows");
        Console.WriteLine("=====================");
    }

    public void PrintNumberedShows(List<Show> shows) {
        foreach (var (show, idx) in shows.Select((show, idx) => (show, idx)))
        {
            Console.WriteLine($"{idx + 1}: {show}");
        }
    }


    public void PrintShows()
    {
        PrintTheatre();
        PrintNumberedShows(shows);
    }
    public void PrintShows(GenreEnum genre)
    {
        PrintTheatre($"{genre} Movies");
        PrintNumberedShows(shows.Where((show) => show.Movie.Genre.HasFlag(genre)).ToList());
    }
    public void PrintShows(DayEnum day)
    {
        PrintTheatre($"Movies on {day}");
        PrintNumberedShows(shows.Where((show) => show.Day == day).ToList());
    }
    public void PrintShows(Time time)
    {
        PrintTheatre($"Movies @{time}");
        PrintNumberedShows(shows.Where((show) => show.Time == time).ToList());
    }
    public void PrintShows(string actor)
    {
        PrintTheatre($"{actor} Movies");
        PrintNumberedShows(shows.Where((show) => show.Movie.Cast.Contains(actor)).ToList());
    }
    public void PrintShows(DayEnum day, Time time)
    {
        PrintTheatre($"{day} movies @{time}");
        PrintNumberedShows(shows.Where((show) => show.Day == day && show.Time == time).ToList());
    }


}
