namespace lab2;

public class Class1
{
    public double balance { get; protected set; } = 100;
    List<int> integers = new List<int>();
    List<double> decimals = new List<double>() { 1.0, 2.0, 3.0 };
    List<Class1> classes = new List<Class1>() { new Class1(1.0), new Class1(2.0) };

    public Class1(double? balance)
    {
        if (balance != null)
        {
            this.balance = (double)balance;
        }
    }

    public void Deposit(double amount)
    {
        balance += amount;

    }

    public double GetBalance()
    {
        return balance;
    }

    private double IncreaseByOne(double amt)
    {
        return (double)(int)amt + 1;
    }

    public static void run()
    {
        Class1 c1 = new Class1(50);
        // Console.WriteLine(c1.balance);
        // c1.Deposit(100);
        // Console.WriteLine(c1.balance);
        // get the length of the list

        foreach (var c in c1.classes) // <--- we use var here because we don't know the type of c, it is variable
        {
            Console.WriteLine(c);
        }


        // for (int i = 0; i < c1.decimals.Count; i++)
        // {
        // Console.WriteLine(c1.decimals[i]);
        // double currentPlusOne = c1.IncreaseByOne(c1.decimals[i]);
        // Console.WriteLine($"currentPlusOne: {currentPlusOne}");
        // Console.WriteLine(c1.decimals[i]);
        // }
    }


}
