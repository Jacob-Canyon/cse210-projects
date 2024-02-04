using System.Dynamic;

namespace Develop04;

public class ListingActivity : Activity
{
    //private int _count = 0;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        _name = "List Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";
        //_count = 0;
        _duration = 0;
        List<string> prompts = new List<string> {"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
        _prompts = prompts;
    }

    public void Run()
    {
        base.DisplayStartingMessage();
        GetUserList();
        base.DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
    }

    public void GetUserList()
    {
        List<string> userList = new List<string>();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.WriteLine();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while(DateTime.Now < endTime)
        {
            Console.Write(">");
            string entry = Console.ReadLine();
            userList.Add(entry);
        }

        Console.WriteLine($"You listed {userList.Count()} things");



    }

}
