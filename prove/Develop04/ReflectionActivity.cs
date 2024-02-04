using System.Security.Cryptography.X509Certificates;

namespace Develop04;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    private List<int> _shuffledList = new List<int>();
    private int _listCount = 0;

    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on the times in your life when you have shown strength and resilience. This will help you recoginze the power you have and how you can use it in other aspects in your life.";
        _duration = 0;
        List<string> prompts = new List<string>{"Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."};
        _prompts = prompts;
        List<string> questions = new List<string>{"Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};
        _questions = questions;
    }

    public void Run()
    {
        base.DisplayStartingMessage();
        GetRandomPrompt();
        GetRandomQuestion();
        DisplayQuestion();
        base.DisplayEndingMessage();

    }

    public void GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        string selectedPrompt = _prompts[index];
        Console.WriteLine(selectedPrompt);
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
    }

    
    public void GetRandomQuestion()
    {
        List<int> listToShuffle = new List<int>();
        listToShuffle.AddRange(Enumerable.Range(0,_questions.Count()));
        Random numberRandom = new Random();
        var shuffledList = listToShuffle.OrderBy(_ =>numberRandom.Next()).ToList();
        
        foreach(int number in shuffledList)
        {
            _shuffledList.Add(number);
        }
    }


    public void DisplayQuestion()
    {  
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while(DateTime.Now < endTime)
        {
            
            int index = _shuffledList[_listCount];
            Console.WriteLine(_questions[index]);
            base.ShowSpinner(7);
            Console.WriteLine();
            _listCount++;
            
            if(_listCount >= _questions.Count())
            {
                _listCount = 0;
            }
            
        }
    }
}
