using System;
using Develop03;

class Program
{
    static void Main(string[] args)
    {
        //I added a system to only choose words that have not been blanked out.

        string selection = "";

        string displayScripture = "But before the great day of the Lord shall come, Jacob shall flouish in the wilderness, and the Lamanintes shall blossom as the rose.";

        Reference reference = new Reference("D&C",49,24);

        Scripture scripture = new Scripture(reference, displayScripture);


     //text for menu----------------------------------------------------------------------------------

        
        Console.WriteLine("Welcome to the scripture memorizer!");
        scripture.GetDiplayText();
        Console.WriteLine("");
        Console.WriteLine("press -enter- to remove words, to exit the program enter -quit-");
        selection = Console.ReadLine();


    //Menu loop-----------------------------------------------------------------------------------------

        
        while (selection != "quit")
        {

        if(selection == "")
        {
            Console.Clear();
            //scripture.IsCompletelyHidden();
            scripture.HideRandomWords(4);
            scripture.GetDiplayText();
            Console.WriteLine("");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("press -enter- to remove words, to exit the program -quit-");
            selection = Console.ReadLine();
        
        }
        }
        
        Console.WriteLine("Goodbye");
        System.Environment.Exit(0);
    }
}