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
        //create a medal object
        Medal m1 = new Medal("Horace Gwynne", "Boxing", MedalColor.Gold, 2012, true);
        //print the object
        Console.WriteLine(m1);
        //print only the name of the medal holder
        Console.WriteLine(m1.name);
        //create another object
        Medal m2 = new Medal("Michael Phelps", "Swimming", MedalColor.Gold, 2012, false);
        //print the updated m2
        Console.WriteLine(m2);


        List<Medal> medals = new List<Medal>() { m1, m2 };
        medals.Add(new Medal("Ryan Cochrane", "Swimming", MedalColor.Silver, 2012, false));
        medals.Add(new Medal("Adam van Koeverden", "Canoeing", MedalColor.Silver, 2012, false));
        medals.Add(new Medal("Rosie MacLennan", "Gymnastics", MedalColor.Gold, 2012, false));
        medals.Add(new Medal("Christine Girard", "Weightlifting", MedalColor.Bronze, 2012, false));
        medals.Add(new Medal("Charles Hamelin", "Short Track", MedalColor.Gold, 2014, true));
        medals.Add(new Medal("Alexandre Bilodeau", "Freestyle skiing", MedalColor.Gold, 2012, true));
        medals.Add(new Medal("Jennifer Jones", "Curling", MedalColor.Gold, 2014, false));
        medals.Add(new Medal("Charle Cournoyer", "Short Track", MedalColor.Bronze, 2014, false));
        medals.Add(new Medal("Mark McMorris", "Snowboarding", MedalColor.Bronze, 2014, false));
        medals.Add(new Medal("Sidney Crosby ", "Ice Hockey", MedalColor.Gold, 2014, false));
        medals.Add(new Medal("Brad Jacobs", "Curling", MedalColor.Gold, 2014, false));
        medals.Add(new Medal("Ryan Fry", "Curling", MedalColor.Gold, 2014, false));
        medals.Add(new Medal("Antoine Valois-Fortier", "Judo", MedalColor.Bronze, 2012, false));
        medals.Add(new Medal("Brent Hayden", "Swimming", MedalColor.Bronze, 2012, false));

        if (medals.Count == 16)
        {
            //prints a numbered list of 16 medals.
            Console.WriteLine("\n\nAll 16 medals");
            foreach (var medal in medals)
            {
                Console.WriteLine(medal);
            }



            //prints a numbered list of 16 names (ONLY)
            Console.WriteLine("\n\nAll 16 names");
            foreach (var medal in medals)
            {
                Console.WriteLine(medal.name);
            }


            //prints a numbered list of 9 gold medals
            Console.WriteLine("\n\nAll 9 gold medals");
            foreach (var item in medals)
            {
                if (item.color == MedalColor.Gold)
                {
                    Console.WriteLine(item);
                }
            }

            //prints a numbered list of 9 medals in 2012
            Console.WriteLine("\n\nAll 9 medals");
            foreach (var item in medals)
            {
                if (item.year == 2012)
                {
                    Console.WriteLine(item);
                }
            }


            //prints a numbered list of 4 gold medals in 2012
            Console.WriteLine("\n\nAll 4 gold medals in 2012");
            foreach (var item in medals)
            {
                if (item.year == 2012 && item.color == MedalColor.Gold)
                {
                    Console.WriteLine(item);
                }
            }


            //prints a numbered list of 3 world record medals
            Console.WriteLine("\n\nAll 3 records");
            foreach (var item in medals)
            {
                if (item.isRecord)
                {
                    Console.WriteLine(item);
                }
            }

            //saving all the medal to file Medals.txt
            Console.WriteLine("\n\nSaving to file");
            bool isFile = File.Exists("Medals.txt");
            if (isFile)
            {
                File.Delete("Medals.txt");
            }
            else
            {
                // FileStream file = File.Create("Medals.txt");
                // @INFO: using (ResourceType resource = new ResourceType()) <-- using statements are used to ensure that the resource is disposed of correctly. The using keyboard disposes of the resource automatically at the end of the block it executes.
                // using (StreamWriter writer = new StreamWriter(file))
                // {
                //     foreach (var medal in medals)
                //     {
                //         writer.WriteLine(medal);
                //     }
                // }
                TextWriter writer = new StreamWriter("Medals.txt");
                foreach (var medal in medals)
                {
                    writer.WriteLine(medal);
                }
                writer.Close();
            }




        }
    }


}
