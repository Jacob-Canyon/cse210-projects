using System;

class Program
{
    static void Main(string[] args)

    {




        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("User Name: ");
            string username = Console.ReadLine();
            return username;
        }

        static int PromptUserNumber()
        {
            Console.Write("Enter your favorite number: ");
            int FavNumber = int.Parse(Console.ReadLine());
            return FavNumber;
        }

        static int SquareNumber(int FavNumber)
        {
            int Square = FavNumber * FavNumber;
            return Square;

        }

        static void DisplayResult(int Square, string name)
        {
            Console.WriteLine($"{name}, this is your number squared {Square}");
        }

        DisplayWelcome();

        string name = PromptUserName();

        int favorite = PromptUserNumber();

        int Square = SquareNumber(favorite);


        DisplayResult(Square, name);

       
    }
}