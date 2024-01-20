using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using Develop02;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string selection = "START";

        Console.WriteLine("Welcome to Your Journal App!");

        promptGenerator prompt1 = new promptGenerator();

        

        Journal journal = new Journal();

        
        


        while(selection != "5")
        {
            Console.WriteLine("Menu Selection:");
            Console.WriteLine("1. Write Journal Entry");
            Console.WriteLine("2. Display Journal Entries");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. End");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("6.T0 DELETE ALL JOURNAL ENTRIES");

            Console.Write("Enter Selection:");
            selection = (Console.ReadLine());

            
            
            if(selection == "1")
            {
                Entry entry = new Entry();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                
            

                string promptText = prompt1.GeneratePrompt();
                Console.WriteLine(promptText);
                

                Console.Write(">");
                string writing = Console.ReadLine();

                
                entry._date = dateText;
                entry._entryText = writing;
                entry._promptText = promptText;

                journal.AddEntry(entry);
               

            }

            
            else if(selection == "2")
            {
                journal.DisplayAll();
            }

            
            
            else if(selection == "3")
            {
                journal.SaveToFile(journal._entries);
            }

            
            
            else if(selection == "4")
            {
                journal.LoadFile(journal._entries);
            }

            
            
            else if(selection == "5")
            {
                System.Environment.Exit(0);
            }

            
            
            else if(selection == "6")
            {
                Console.WriteLine("Would you like to clear all journal entiers? Y/N");
                string answer = Console.ReadLine();

                if(answer == "Y")
                {
                    journal.ClearFile();

                    Console.WriteLine("Journal Deleted");
                }

                Console.WriteLine("Clear Journal Canceled \n");


            }
  

            else
            {
                Console.WriteLine("Invalid Selection");
            }




        }
    }
}