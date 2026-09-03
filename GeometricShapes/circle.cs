using WorkShop._2.Backend;

public class Circle : Geometric
{
    //Fields

    private double _r;

    // Constructor
    public Circle(string name, double r)
    {
        R = r;
        Name = name;
    }

    // Properties 

    public double R
    {
        get => _r;
        set => _r = ValidateR(value);
    }

    //Methods

    public override double GetArea() => Math.PI * R * R;

    public override double GetPerimeter() => 2 * Math.PI * R;

    // Valides
    private double ValidateR(double r)
    {
        if (r <= 0)
        {
            throw new ArgumentException("The radium of the circle is incorrect.");
        }
        return r;
    }
}