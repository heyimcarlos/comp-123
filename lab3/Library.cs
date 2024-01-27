namespace lab3;

static class Library
{
    private static List<Song> songs = new List<Song>();

    public static void LoadSongs(string fileName)
    {
        TextReader reader = new StreamReader($"bin/Debug/{fileName}");

        while (true)
        {
            string? name = reader.ReadLine();
            string artist = reader.ReadLine() ?? "";
            double length = Convert.ToDouble(reader.ReadLine());
            SongGenre genre = Enum.Parse<SongGenre>(reader.ReadLine() ?? SongGenre.Unclassified.ToString());

            if (name == null)
            {
                reader.Close();
                break;
            }
            songs.Add(new Song(name, artist, length, genre));
        }
    }

    public static void DisplaySongs()
    {
        foreach (var song in songs)
        {
            Console.WriteLine(song);
        }
    }

    public static void DisplaySongs(double longerThan)
    {
        foreach (var song in songs)
        {
            if (song.length > longerThan)
            {
                Console.WriteLine(song);
            }
        }
    }

    public static void DisplaySongs(SongGenre genre)
    {
        foreach (var song in songs)
        {
            if (song.genre.HasFlag(genre))
            {
                Console.WriteLine(song);
            }
        }
    }

    public static void DisplaySongs(string artist)
    {
        foreach (var song in songs)
        {
            if (song.artist == artist)
            {
                Console.WriteLine(song);
            }
        }
    }

    public static void test()
    {
        //To test the constructor and the ToString method
        Console.WriteLine(new Song("Baby", "Justin Bebier", 3.35, SongGenre.Pop));

        //This is first time that you are using the bitwise or. It is used to specify a combination of genres
        Console.WriteLine(new Song("The Promise", "Chris Cornell", 4.26, SongGenre.Country | SongGenre.Rock));

        Library.LoadSongs("songs4.txt"); //Class methods are invoke with the class name
        Console.WriteLine("\n\nAll songs");
        Library.DisplaySongs();

        SongGenre genre = SongGenre.Rock;
        Console.WriteLine($"\n\n{genre} songs");
        Library.DisplaySongs(genre);

        string artist = "Bob Dylan";
        Console.WriteLine($"\n\nSongs by {artist}");
        Library.DisplaySongs(artist);

        double length = 5.0;
        Console.WriteLine($"\n\nSongs more than {length}mins");
        Library.DisplaySongs(length);
    }

}
