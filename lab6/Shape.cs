namespace lab6;

abstract class Shape
{
    public string Name { get; protected set; }
    public abstract double Area { get; }

    public Shape(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return Name + " Area: " + string.Format("{0:0.00}", Area);
    }

    public static void run()
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("s1", 2));
        shapes.Add(new Rectangle("r1", 2, 3));
        shapes.Add(new Circle("c1", 2));
        shapes.Add(new Triangle("t1", 4, 6));
        shapes.Add(new Ellipse("e1", 2, 3));
        shapes.Add(new Diamond("d1", 2, 3));
        shapes.Add(new Square("s2", 5));
        shapes.Add(new Rectangle("r2", 5, 4));
        shapes.Add(new Circle("c2", 1));
        shapes.Add(new Triangle("t2", 7, 8));
        foreach (var s in shapes)
        {
            Console.WriteLine(s);
        }
    }
}

class Square : Shape
{
    public double Length { get; protected set; }
    public override double Area { get; }

    public Square(string name, double length) : base(name)
    {
        Length = length;
        Area = Math.Pow(Length, 2);
    }
}

class Circle : Square
{
    public override double Area => Math.PI * Math.Pow(Length, 2);

    public Circle(string name, double length) : base(name, length)
    { }
}

class Rectangle : Shape
{
    public double Width { get; protected set; }
    public double Height { get; protected set; }
    public override double Area => Width * Height;

    public Rectangle(string name, double height, double width) : base(name)
    {
        Height = height;
        Width = width;
    }
}

class Ellipse : Rectangle
{
    public override double Area => Math.PI * Width * Height;

    public Ellipse(string name, double height, double width) : base(name, height, width) { }
}

class Triangle : Rectangle
{
    public override double Area => Width * Height * 0.5;

    public Triangle(string name, double height, double width) : base(name, height, width) { }
}

class Diamond : Rectangle
{
    public override double Area => Width * Height * 0.5;

    public Diamond(string name, double height, double width) : base(name, height, width) { }
}
