using System.Drawing;

public class Parallelogram : Rectangle
{
    //Fields

    private double _h;

    // Constructor

    public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
    {
        H = h;
    }

    // Properties 

    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }


    //Methods

    public override double GetArea() => B * H;

    public override double GetPerimeter() => base.GetPerimeter();

    // Valides
    private double ValidateH(double h)
    {
        if (h <= 0)
        {
            throw new ArgumentException("The area of the Parallelogram is incorrect.");
        }
        return h;
    }
}