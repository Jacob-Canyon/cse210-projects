using System.Formats.Asn1;

namespace Learning05;

public class Square :  Shape
{
    private double _side = 0;


    public Square(string color, double side)
    {
        _side = side;
        SetColor(color);
    }


    public override double GetArea()
    {   
        double area = _side * _side;
        return area;
    }


}
