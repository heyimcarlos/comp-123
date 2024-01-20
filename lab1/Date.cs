namespace lab1;

public class Date
{
    private int year;
    private int month;
    private int day;

    public Date(int day = 1, int month = 1, int year = 2022)
    {
        this.day = day;
        this.month = month;
        this.year = year;

        Normalize();
    }

    public override string ToString()
    {
        return $"{GetMonthName()} {day}, {year}";
    }

    public void Add(int days)
    {
        day += days;

        Normalize();
    }

    public void Add(int days, int months)
    {
        day += days;
        month += months;

        Normalize();
    }

    public void Add(Date other)
    {
        day += other.day;
        month += other.month;
        year += other.year;

        Normalize();
    }

    public void Normalize()
    {
        int daysInMonth = DateTime.DaysInMonth(year, month);
        while (day > daysInMonth)
        {
            day -= daysInMonth;
            month++;
            if (month > 12)
            {
                year += month / 12;
                month = month % 12;
            }
            daysInMonth = DateTime.DaysInMonth(year, month);
        }
    }

    public string GetMonthName()
    {
        return new DateTime(year, month, day).ToString("MMMM");
    }

    public static void run()
    {
        Date date = new Date(1, 1, 2022);
        Console.WriteLine($"Current date: {date}");

        date.Add(365);
        Console.WriteLine($"date after adding 365 days: {date}");

        date.Add(2, 2);
        Console.WriteLine($"date after adding 2 days and 2 months: {date}");

        date.Add(new Date(3, 3, 2));
        Console.WriteLine($"date after adding 3 days, 3 months, and 2 years: {date}");
    }
}
