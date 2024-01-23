using System;
using Learning03;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDemcialValue());

        Fraction fraction2 = new Fraction(3,4);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDemcialValue());

        Fraction fraction3 = new Fraction(1);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDemcialValue());

        Fraction fraction4 = new Fraction(1,3);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDemcialValue());

        Fraction fraction = new Fraction();
        fraction.SetTop(5);
        fraction.SetBottom(4);
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDemcialValue());
        

    }

}