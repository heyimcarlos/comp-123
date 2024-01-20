namespace lab2;

public class Pet
{
    public string name { get; }
    public string owner { get; private set; }
    public int age { get; }
    public string description { get; }
    public bool isHouseTrained { get; private set; }

    public Pet(string name, int age, string description)
    {
        this.name = name;
        this.age = age;
        this.description = description;
        this.owner = "no one";
        this.isHouseTrained = false;
    }

    public override string ToString()
    {
        string houseTrained = isHouseTrained ? "is" : "is not";
        return $"{name} is {age} years old, {description}, {houseTrained} house trained, and is owned by {owner}";
    }

    public void Train()
    {
        isHouseTrained = true;
    }

    public void SetOwner(string owner)
    {
        this.owner = owner;
    }

    public static void run()
    {
        Pet p1 = new Pet("Jim", 5, "a rottweiler dog");
        Pet p2 = new Pet("Pacco", 2, "a chihuahua dog");
        Pet p3 = new Pet("Hulk", 5, "a siamese cat");
        Pet p4 = new Pet("Leonidas", 5, "a grey ferret");

        List<Pet> pets = new List<Pet>() { p1, p2, p3, p4 };

        p1.Train();
        p2.SetOwner("Carlos");
        p3.SetOwner("Lucy");
        p4.Train();
        p4.SetOwner("Pedro");
        p1.SetOwner("Carlos");

        foreach (var pet in pets)
        {
            Console.WriteLine(pet);
        }

        Console.Write("\nEnter an owner's name: ");
        string? owner = Console.ReadLine()?.ToLower();
        Console.WriteLine(owner);

        if (owner == null || owner == "")
        {
            Console.WriteLine("No owner entered");
            return;
        }
        foreach (var pet in pets)
        {
            if (pet.owner.ToLower() == owner)
            {
                Console.WriteLine(pet);
            }
        }


    }

}
