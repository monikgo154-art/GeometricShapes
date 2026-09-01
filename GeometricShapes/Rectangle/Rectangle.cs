public class Rectangle : Square
{
    //Fields

    private double _b;

    // Constructor
    public Rectangle(string name, double a, double b) : base(name, a)
    {
        B = b;
    }

    // Properties 

    public double B
    {
        get => _b;
        set => _b = ValidateB(value);
    }


    //Methods

    public override double GetArea() => A * B;

    public override double GetPerimeter() => 2 * (A + B);

    // Valides
    private double ValidateB(double b)
    {
        if (b <= 0)
        {
            throw new ArgumentException("The area of the rectangle is incorrect.");
        }
        return b;
    }
}