using System;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        Console.Write(" What grade precentage did you get?" );
        string GradePercent = Console.ReadLine();
        
        int x = int.Parse(GradePercent);

        string letter = "";

        if (x >= 90)
        {
            letter = "A";
        }

        else if (x >= 80)
        {
            letter = "B";
        }
        
        else if (x >= 70)
        {
            letter = "C";
        }

        else if (x >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        if (x >= 70)
        {
            Console.WriteLine("Congrats you pass the class!");
        }

        else
        {
            Console.WriteLine("Don't give up, You get it next time");
        }




    

    }
}