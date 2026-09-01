namespace Trapaze
{
    public class Trapeze : Triangle
    {
        //Fields

        private double _d;

        // Constructor

        public Trapeze(string name, double a, double b, double c, double h, double d) : base(name, a, b, c, h)
        {
            D = d;
        }

        // Properties 

        public double D
        {
            get => _d;
            set => _d = ValidateD(value);
        }

        //Methods

        public override double GetArea() => ((B + D) * H) / 2;

        public override double GetPerimeter() => A + B + C + D;

        // Valides
        private double ValidateD(double d)
        {
            if (d <= 0)
            {
                throw new ArgumentException("The length of the Trapeze is incorrect.");
            }
            return d;
        }

    }
