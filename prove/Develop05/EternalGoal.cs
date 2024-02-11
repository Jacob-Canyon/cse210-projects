namespace Develop05;

public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }


    public override void RecordEvent()
    {
       
        Console.WriteLine($"Congratulions! You have earned {_points}");
        
    }

    public override void IsComplete()
    {
        throw new NotImplementedException();
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }
}
