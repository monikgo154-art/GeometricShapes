using WorkShop._2.Backend;

public class Triangle : Rectangle
{
    //Fields

    private double _c;
    private double _h;

    // Constructor

    public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
    {
        C = c;
        H = h;
    }

    // Properties 

    public double C
    {
        get => _c;
        set => _c = ValidateC(value);
    }

    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    //Methods

    public override double GetArea() => (B * H) / 2;

    public override double GetPerimeter() => A + B + C;

    // Valides
    private double ValidateC(double c)
    {
        if (c <= 0)
        {
            throw new ArgumentException("The length of the triangle is incorrect.");
        }
        return c;
    }

    private double ValidateH(double h)
    {
        if (h <= 0)
        {
            throw new ArgumentException("The height of the rectangle is incorrect.");
        }
        return h;
    }
}
