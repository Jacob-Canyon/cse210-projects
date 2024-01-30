using System;
using Learning04;

class Program
{
    static void Main(string[] args)
    {
        //Assignment assignment = new Assignment("Jacob Canyon","Math");

        //Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Jacob Canyon","Math", "Algebra", "1-25");

        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkAssignment());

        WritingAssignment writingAssignment = new WritingAssignment("Jacob Canyon","History","World War II by John Smith");


        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingAssignment());


    }
}