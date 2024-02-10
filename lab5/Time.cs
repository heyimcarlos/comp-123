namespace lab5;

struct Time
{
    public int Hours { get; }
    public int Minutes { get; }

    public Time(int hours, int minutes = 0)
    {
        Hours = hours;
        Minutes = minutes;
    }

    public override string ToString()
    {
        return $"{Hours}:{Minutes:D2}";
    }

    public static bool operator ==(Time lhs, Time rhs)
    {
        int totalMinutesLHS = (lhs.Hours * 60) + lhs.Minutes;
        int totalMinutesRHS = (rhs.Hours * 60) + rhs.Minutes;
        return Math.Abs(totalMinutesLHS - totalMinutesRHS) <= 15;
    }

    public static bool operator !=(Time lhs, Time rhs)
    {
        int totalMinutesLHS = (lhs.Hours * 60) + lhs.Minutes;
        int totalMinutesRHS = (rhs.Hours * 60) + rhs.Minutes;
        return Math.Abs(totalMinutesLHS - totalMinutesRHS) > 15;
    }

}
