using System.ComponentModel;

namespace Develop05;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, string points,string checkbox)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _checkbox = checkbox;
    }


    public SimpleGoal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public override int GetPoints()
    {
        if (_checkbox != "[x]")
        {
            int addPoints = int.Parse(_points);
            return addPoints;

        }

        else
        {
            return 0;
        }
    }

    public override void RecordEvent()
    {
        if (_checkbox != "[x]")
        {
            Console.WriteLine($"Congratulions! You have earned {_points}");
            IsComplete();

        }

        else
        {
            Console.WriteLine("Goal already completed.");
        }
    }

    public override void IsComplete()
    {
        _checkbox = "[x]";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_checkbox}";
    }
}
