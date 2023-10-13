namespace Learning05;

public class Circle : Shape
{
    public double _radius;
    public Circle(string color, double radius) : base(color)
    {
        this._radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * (_radius * _radius);
    }
}