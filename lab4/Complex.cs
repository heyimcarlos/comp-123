namespace lab4;

class Complex
{
    public int Real { get; }
    public int Imaginary { get; }

    public double Argument => Math.Atan((double)Imaginary / Real);
    public double Modulus => Math.Sqrt(Math.Pow(Real, 2) + Math.Pow(Imaginary, 2));

    // this is anothe way to define computed properties
    // public double Argument { get { return Math.Atan((double)Imaginary / Real); } }
    // public double Modulus { get { return Math.Sqrt(Math.Pow(Real, 2) + Imaginary); } }

    // factory property
    public static Complex Zero = new Complex();

    // operator overloading +, ==, !=, *
    public Complex(int real = 0, int imaginary = 0)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public override string ToString()
    {
        return $"({Real},{Imaginary})";
    }

    // @INFO: operator overloading. The operator keyword and then the sign of the operator to overload followed by the operands.
    public static Complex operator +(Complex lhs, Complex rhs)
    {
        int real = lhs.Real + rhs.Real;
        int imaginary = lhs.Imaginary + rhs.Imaginary;
        return new Complex(real, imaginary);
    }
    public static Complex operator -(Complex lhs, Complex rhs)
    {
        int real = lhs.Real - rhs.Real;
        int imaginary = lhs.Imaginary - rhs.Imaginary;
        return new Complex(real, imaginary);
    }
    // @INFO: this operator has to be overloaded in pair with !=
    public static bool operator ==(Complex lhs, Complex rhs)
    {
        bool isReal = lhs.Real == rhs.Real;
        bool isImaginary = lhs.Imaginary == rhs.Imaginary;
        return isReal && isImaginary;
    }
    public static bool operator !=(Complex lhs, Complex rhs)
    {
        bool isReal = lhs.Real != rhs.Real;
        bool isImaginary = lhs.Imaginary != rhs.Imaginary;
        return isReal || isImaginary;
    }
    public static Complex operator *(Complex lhs, Complex rhs)
    {
        int real = lhs.Real * rhs.Real - lhs.Imaginary * rhs.Imaginary;
        int imaginary = lhs.Real * rhs.Imaginary + lhs.Imaginary * rhs.Real;
        return new Complex(real, imaginary);
    }
    public static Complex operator -(Complex lhs)
    {
        return new Complex(-lhs.Real, -lhs.Imaginary);
    }

    public static void run()
    {
        Complex c0 = new Complex(-2, 3);
        Complex c1 = new Complex(-2, 3);
        Complex c2 = new Complex(1, -2);
        Console.WriteLine($"{c0}");
        Console.WriteLine(c1);
        Console.WriteLine(c2);
        Console.WriteLine($"{c1} + {c2} = {c1 + c2}");
        Console.WriteLine($"{c1} - {c2} = {c1 - c2}");
        Complex c3 = c1 + c2;
        Console.WriteLine($"{c3} in polar form is {c3.Modulus:f2}cis({c3.Argument:f2})");
        Console.WriteLine($"{c0} {(c0 == c1 ? "=" : "!=")} {c1}");
        Console.WriteLine($"{c0} {(c0 == c2 ? "=" : "!=")} {c2}");
        Console.WriteLine($"{c1} * {c2} = {c1 * c2}");
        Console.WriteLine($"-{c1} = {-c1}");
    }


}
