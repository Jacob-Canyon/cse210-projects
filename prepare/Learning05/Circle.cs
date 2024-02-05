using System.Formats.Asn1;

namespace Learning05;

public class Circle : Shape
{
    private double _radius = 0;


    public Circle(string color, double radius)
    {
        _radius = radius;
        SetColor(color);
    }

    public override double GetArea()
    {
        double area = Math.PI * _radius * _radius;
        return area;
    }
}
