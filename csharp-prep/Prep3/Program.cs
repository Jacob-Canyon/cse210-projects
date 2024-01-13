using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int Number = randomGenerator.Next(1,11);

        int Guess = 0;

  
        

        while (Guess != Number)
        {

            Console.Write("Guess the Magic Number? ");

            Guess = int.Parse(Console.ReadLine());

            
           

            if ( Guess > Number)
            {
                Console.WriteLine(" Too High");

                    
            }

            else if (Guess < Number)
            {
                Console.WriteLine("Too Low");
            }

            else
            {
                Console.WriteLine("You got the Magic Number");

            }

        }

        
            

        

        
    }
}