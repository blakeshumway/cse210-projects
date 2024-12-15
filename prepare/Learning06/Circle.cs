public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base (color)
    {
        _radius = radius;
    }

    //overide changes the method to be unique to the class
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}