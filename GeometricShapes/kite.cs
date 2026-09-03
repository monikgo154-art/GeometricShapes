public class Kite : Rhombus
{
    //Fields

    private double _b;

    // Constructor
    public Kite(string name, double a, double d1, double d2, double b) : base(name, a, d1, d2)
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

    public override double GetArea() => base.GetArea();

    public override double GetPerimeter() => 2 * (A + B);


    // Valides
    private double ValidateB(double b)

    {
        if (b <= 0)
        {
            throw new ArgumentException("The diagonal b of the Kite is incorrect");
        }
        return b;
    }

}
}
