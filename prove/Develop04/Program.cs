using System;
using Develop04;

class Program
{
    static void Main(string[] args)

    {   
        Console.WriteLine("Welcome to the Mindfulness App!");

        string selection = "";

        while(selection != "4")
        {
            
            Console.WriteLine("Please make a selection from below.\n");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit\n");
            
            Console.Write("Enter Selection: ");
            selection = Console.ReadLine();

            if(selection == "1")
            {
                BreatheActivity breathe = new BreatheActivity();
                breathe.Run();
            }

            if(selection == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
            }

            if(selection == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();

                
            }

            if(selection == "4")
            {
                System.Environment.Exit(0);
            }

            else
            {
                
            }
        }

    }
}