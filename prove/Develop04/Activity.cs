using System.Runtime.Versioning;

namespace Develop04;

public class Activity
{
    protected string _name = "";
    protected string _description = "";
    protected int _duration = 0;

    public Activity()
    {
    }


    public void DisplayStartingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Welcome to the {_name}");
        ShowSpinner(4);
        Console.WriteLine();
        Console.WriteLine(_description);
        ShowSpinner(3);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like your secession for?");
        int secession = int.Parse(Console.ReadLine());
        _duration = secession;
        Console.Write("Get ready...");
        ShowSpinner(5);
        Console.WriteLine("\n");
    
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!!");
        Console.WriteLine();
        ShowSpinner(5);
        Console.WriteLine($"You have completeld another {_duration} seconds of the {_name}");
        ShowSpinner(7);
    }

    public void ShowCountDown()
    {
        for (int i =5; i > 0;i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void ShowSpinner(int seconds)
    {
        List<string> frames =  new List<string>{"-","\\","|","/","-","\\","|","/","-"};

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while(DateTime.Now < endTime)
        {
            string frame = frames[i];
            Console.Write(frame);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= frames.Count)
            {
                i = 0;
            }

        
        }
        
           
        
    }

    
}
