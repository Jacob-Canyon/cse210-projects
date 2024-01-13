using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int Number = -1;

        Console.WriteLine("Add numbers to the list. Enter 0 to finish");
        Console.WriteLine("");

        while (Number != 0)
        {
            

            Console.Write("Enter number: ");
            Number = int.Parse(Console.ReadLine());

            numbers.Add(Number);
        }

        int total = numbers.Sum();
        Console.WriteLine($"The Sum is: {total}");

        int avgnumber = numbers.Count - 1;

        int average = total / avgnumber;

        Console.WriteLine($"The average is: {average}");

        Console.WriteLine("The largest number is: " + numbers.Max());

    }
}