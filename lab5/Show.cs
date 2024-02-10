namespace lab5;

struct Show
{
    public double Price { get; }
    public DayEnum Day { get; }
    public Movie Movie { get; }
    public Time Time { get; }

    public Show(Movie movie, Time time, DayEnum day, double price)
    {
        Movie = movie;
        Time = time;
        Day = day;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Day} {Time} {Movie.Title} ({Movie.Year}) {Movie.Length}min ({Movie.Genre.ToString()}) {string.Join(", ", Movie.Cast)} {Price:C}";
    }
}
