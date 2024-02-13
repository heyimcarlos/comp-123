namespace lab4;

using System.Xml.Serialization;
using System.Text.Json;

public class Atom
{
    public string Name { set; }
    public string Symbol { set; }
    public int Proton { set; }
    public int Neutron { set; }
    public double Weight { set; }

    // important to have a parameterless constructor for serialization
    public Atom() { }

    public Atom(string name, int proton, int neutron, double weight, string symbol)
    {
        Name = name;
        Proton = proton;
        Neutron = neutron;
        Weight = weight;
        Symbol = symbol;
    }

    public override string ToString()
    {
        return $"{Name} ({Symbol}) has {Proton} protons and {Neutron} neutrons. The weight is {Weight}";
    }

    public static Atom Parse(string objectData)
    {
        string[] parts = objectData.Split(" ");
        if (parts.Length != 5)
        {
            throw new ArgumentException("The string is not in the correct format");
        }
        return new Atom(parts[0], Convert.ToInt32(parts[1]), Convert.ToInt32(parts[2]), Convert.ToDouble(parts[3]), parts[4]);
    }

    public static List<Atom> GetAtoms()
    {
        List<Atom> elements = new List<Atom>();
        elements.Add(Atom.Parse("Hydrogen 1 0 1.0079 H"));
        elements.Add(Atom.Parse("Helium 2 2 4.0026 He")); ;
        elements.Add(Atom.Parse("Lithium 3 4 6.941 Li")); ;
        elements.Add(Atom.Parse("Beryllium 4 5 9.0122 Be"));
        elements.Add(Atom.Parse("Boron 5 6 10.811 B"));
        elements.Add(Atom.Parse("Carbon 6 6 12.0107 C"));
        elements.Add(Atom.Parse("Nitrogen 7 7 14.0067 N"));
        elements.Add(Atom.Parse("Oxygen 8 8 15.9994 O"));
        elements.Add(Atom.Parse("Fluorine 9 10 18.9984 F"));
        elements.Add(Atom.Parse("Neon 10 10 20.1797 Ne"));
        elements.Add(Atom.Parse("Sodium 11 12 22.9897 Na"));
        elements.Add(Atom.Parse("Magnesium 12 12 24.305 Mg"));
        elements.Add(Atom.Parse("Aluminum 13 14 26.9815 Al"));
        elements.Add(Atom.Parse("Silicon 14 14 28.0855 Si"));
        elements.Add(Atom.Parse("Phosphorus 15 16 30.9738 P"));
        elements.Add(Atom.Parse("Sulfur 16 16 32.065 S"));
        elements.Add(Atom.Parse("Chlorine 17 18 35.453 Cl"));
        elements.Add(Atom.Parse("Potassium 19 20 39.0983 K"));
        elements.Add(Atom.Parse("Argon 18 22 39.948 Ar"));
        elements.Add(Atom.Parse("Calcium 20 20 40.078 Ca"));
        elements.Add(Atom.Parse("Scandium 21 24 44.9559 Sc"));
        elements.Add(Atom.Parse("Titanium 22 26 47.867 Ti"));
        elements.Add(Atom.Parse("Vanadium 23 28 50.9415 V"));
        elements.Add(Atom.Parse("Chromium 24 28 51.9961 Cr"));
        elements.Add(Atom.Parse("Manganese 25 30 54.938 Mn"));
        elements.Add(Atom.Parse("Iron 26 30 55.845 Fe"));
        elements.Add(Atom.Parse("Nickel 28 31 58.6934 Ni"));
        elements.Add(Atom.Parse("Cobalt 27 32 58.9332 Co"));
        elements.Add(Atom.Parse("Copper 29 35 63.546 Cu"));
        elements.Add(Atom.Parse("Zinc 30 35 65.39 Zn"));
        elements.Add(Atom.Parse("Gallium 31 39 69.723 Ga"));
        elements.Add(Atom.Parse("Germanium 32 41 72.64 Ge"));
        elements.Add(Atom.Parse("Arsenic 33 42 74.9216 As"));
        elements.Add(Atom.Parse("Selenium 34 45 78.96 Se"));
        elements.Add(Atom.Parse("Bromine 35 45 79.904 Br"));
        elements.Add(Atom.Parse("Krypton 36 48 83.8 Kr"));
        elements.Add(Atom.Parse("Rubidium 37 48 85.4678 Rb"));
        elements.Add(Atom.Parse("Strontium 38 50 87.62 Sr"));
        elements.Add(Atom.Parse("Yttrium 39 50 88.9059 Y"));
        elements.Add(Atom.Parse("Zirconium 40 51 91.224 Zr"));
        elements.Add(Atom.Parse("Niobium 41 52 92.9064 Nb"));
        elements.Add(Atom.Parse("Molybdenum 42 54 95.94 Mo"));
        elements.Add(Atom.Parse("Technetium 43 55 98 Tc"));
        elements.Add(Atom.Parse("Ruthenium 44 57 101.07 Ru"));
        elements.Add(Atom.Parse("Rhodium 45 58 102.9055 Rh"));
        elements.Add(Atom.Parse("Palladium 46 60 106.42 Pd"));
        elements.Add(Atom.Parse("Silver 47 61 107.8682 Ag"));
        elements.Add(Atom.Parse("Cadmium 48 64 112.411 Cd"));
        elements.Add(Atom.Parse("Indium 49 66 114.818 In"));
        elements.Add(Atom.Parse("Meitnerium 109 159 268 Mt"));
        elements.Add(Atom.Parse("Roentgenium 111 161 272 Rg"));
        elements.Add(Atom.Parse("Hassium 108 169 277 Hs"));
        return elements;
    }

    public static void ListAtoms(List<Atom> atoms)
    {
        foreach (var atom in atoms)
        {
            Console.WriteLine(atom);
        }
    }

    public static void WriteXml(List<Atom> atoms, string filename)
    {
        XmlSerializer ser = new XmlSerializer(typeof(Atom));
        StreamWriter writer = new StreamWriter(filename);
        ser.Serialize(writer, atoms[0]);
        writer.Close();
    }

    public static void ReadXml(string filename)
    {
        XmlSerializer ser = new XmlSerializer(typeof(Atom));
        StreamReader reader = new StreamReader(filename);
        Atom? atom = ser.Deserialize(reader) as Atom;
        Console.WriteLine(atom);
    }

    public static void WriteJson(Atom atom, string filename)
    {
        string json = JsonSerializer.Serialize(atom);
        File.WriteAllText(filename, json);
    }

    public static void WriteJson(List<Atom> atoms, string filename)
    {
        string json = JsonSerializer.Serialize(atoms);
        File.WriteAllText(filename, json);
    }

    public static void ReadJson(string filename)
    {
        string json = File.ReadAllText(filename);
        Atom? atom = JsonSerializer.Deserialize<Atom>(json);
        if (atom != null)
        {
            Console.WriteLine(atom);
        }
    }

    public static void ReadAllJson(string filename)
    {
        string json = File.ReadAllText(filename);
        Atom[]? atoms = JsonSerializer.Deserialize<Atom[]>(json);
        if (atoms != null)
        {
            foreach (var atom in atoms)
            {
                Console.WriteLine(atom);
            }
        }
    }

    public static void run()
    {
        List<Atom> atoms = Atom.GetAtoms();
        Console.WriteLine("Start List of atoms");
        Atom.ListAtoms(atoms);
        Console.WriteLine("End List of atoms\n");

        Console.WriteLine("Start Write XML");
        Atom.WriteXml(atoms, "hydrogen.xml");
        Atom.ReadXml("hydrogen.xml");
        Console.WriteLine("End ReadXML\n");

        Console.WriteLine("Start Write single Json");
        Atom.WriteJson(atoms[0], "hydrogen.json");
        Atom.ReadJson("hydrogen.json");
        Console.WriteLine("End Read single Json\n");

        Console.WriteLine("Start Write Json");
        Atom.WriteJson(atoms, "atoms.json");
        Atom.ReadAllJson("atoms.json");
        Console.WriteLine("End Read Json\n");
    }
}
