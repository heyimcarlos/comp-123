namespace lab3;

enum TimeFormat
{
    Mil,
    Hour12,
    Hour24
}

class Time
{
    private static TimeFormat TIME_FORMAT = TimeFormat.Hour12;
    public int hour;
    public int minute;

    public Time(int hour = 0, int minute = 0)
    {
        this.hour = hour > 0 && hour <= 24 ? hour : 0;
        this.minute = minute > 0 && minute <= 60 ? minute : 0;
    }

    public override string ToString()
    {
        switch (TIME_FORMAT)
        {
            case TimeFormat.Mil:
                return $"{hour:d2}{minute:d2}";
            case TimeFormat.Hour12:
                return $"{hour % 12}:{minute:d2} {(hour >= 12 ? "PM" : "AM")}";
            case TimeFormat.Hour24:
                return $"{hour:00}:{minute:d2}";
            default:
                return $"{hour:00}:{minute:d2}";
        };
    }

    public static void SetFormat(TimeFormat time_format)
    {
        TIME_FORMAT = time_format;
    }

    public static void test()
    {

        //create a list to store the objects
        List<Time> times = new List<Time>()
        {
            new Time(9, 35),
            new Time(18, 5),
            new Time(20, 500),
            new Time(10),
            new Time()
        };

        // //display all the objects
        TimeFormat format = TimeFormat.Hour12;
        Console.WriteLine($"\n\nTime format is {format}");
        foreach (Time t in times)
        {
            Console.WriteLine(t);
        }

        //change the format of the output
        format = TimeFormat.Mil;
        Console.WriteLine($"\n\nSetting time format to {format}");
        //SetFormat(TimeFormat) is a class member, so you need the type to access it
        Time.SetFormat(format);
        //again display all the objects
        foreach (Time t in times)
        {
            Console.WriteLine(t);
        }

        //change the format of the output
        format = TimeFormat.Hour24;
        Console.WriteLine($"\n\nSetting time format to {format}");
        //SetFormat(TimeFormat) is a class member, so you need the type to access it
        Time.SetFormat(format);
        foreach (Time t in times)
        {
            Console.WriteLine(t);
        }
    }

}
