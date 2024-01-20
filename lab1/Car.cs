namespace lab1;

public class Car
{
    private int year;
    private string model;
    private bool isDrivable;
    private double price;

    public Car(int year, string model, double price, bool isDrivable = true)
    {
        this.year = year;
        this.model = model;
        this.price = price;
        this.isDrivable = isDrivable;
    }

    public override string ToString()
    {
        return $"Year: {year}, Model: {model}, Price: {price}, Is Drivable: {isDrivable}";
    }

    public string GetIsDrivable()
    {
        string isDrivable = this.isDrivable ? "Yes" : "No";
        Console.WriteLine($"Is the {this.model} drivable? {isDrivable}\n");
        return isDrivable;
    }

    public static void run()
    {
        Car c1 = new Car(2010, "Toyota Land Cruiser", 100000.25);
        Console.WriteLine(c1);
        c1.GetIsDrivable();

        Car c2 = new Car(2019, "Tesla Model 3", 50000.00, false);
        Console.WriteLine(c2);
        c2.GetIsDrivable();

        Car c3 = new Car(2017, "Ford F150", 25550.64);
        Console.WriteLine(c3);
        c3.GetIsDrivable();

        Car c4 = new Car(2013, "Honda Accord", 18200, false);
        Console.WriteLine(c4);
        c4.GetIsDrivable();
    }
}
