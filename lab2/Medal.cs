namespace lab2;

public enum MedalColor { Gold, Silver, Bronze };

public class Medal
{

    public string name { get; }
    public string theEvent { get; }
    public MedalColor color { get; }
    public int year { get; }
    public bool isRecord { get; }

    public Medal(string name, string theEvent, MedalColor color, int year, bool isRecord)
    {
        this.name = name;
        this.theEvent = theEvent;
        this.color = color;
        this.year = year;
        this.isRecord = isRecord;
    }

    public override string ToString()
    {
        string record = isRecord ? "(R)" : "";
        return $"{year} - {theEvent}{record} {name}({color})";
    }

    public static void run()
    {
        Medal m1 = new Medal("Carlos", "100m", MedalColor.Bronze, 2021, false);
    }


}
