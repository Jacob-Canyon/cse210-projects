namespace Develop04;

public class BreatheActivity  : Activity
{

    public BreatheActivity()
    {
        _name = "Breathe Activity";
        _description = "This Activity will help you clam your mind by guiding your breathing.";
        _duration = 0;

    }

    public void Run()
    {
        base.DisplayStartingMessage();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);


        while(DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            base.ShowCountDown();
            Console.WriteLine();
            Console.Write("Breathe out...");
            base.ShowCountDown();
            Console.WriteLine();

        }

        base.DisplayEndingMessage();
       
    

        
    }

}
