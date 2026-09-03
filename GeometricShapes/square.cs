public class Square : Geometric
{
    //Fields

    private double _a;

    // Constructor
    public Square(string name, double a)
    {
        A = a;
        Name = name;
    }

    // Properties 

    public double A
    {
        get => _a;
        set => _a = ValidateA(value);
    }

    //Methods

    public override double GetArea() => A * A;

    public override double GetPerimeter() => 4 * A;

    // Valides
    private double ValidateA(double a)
    {
        if (a <= 0)
        {
            throw new ArgumentException("The area of the square is incorrect.");
        }
        return a;
    }
}
