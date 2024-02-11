using System.ComponentModel;

namespace Develop05;

public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target = 0;
    private int _bonus = 0;

    public ChecklistGoal(string name, string description, string points, int completed, int target, int bonus)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _amountCompleted = completed;
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, string points, string checkbox, int completed, int target, int bonus)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _checkbox = checkbox;
        _amountCompleted = completed;
        _target = target;
        _bonus = bonus;
    }

    public override int GetPoints()
    {
        if(_amountCompleted >= _target)
        {
            return 0;
        }

        else
        {
            int addPoints = int.Parse(_points);
            addPoints = addPoints + _bonus;
            return addPoints;

        }
    }

    public override void RecordEvent()
    {
        if(_amountCompleted < _target)
        {
            Console.WriteLine($"Congratulions! You have earned {_points}");
            _amountCompleted++;
        }

        if(_amountCompleted == _target)
        {
            Console.WriteLine($"Congratulions! You have earned {_points}");
            Console.WriteLine($"and a Bouns of {_bonus} for finishing the checklist");
            int points = int.Parse(_points);
            int addedPoints = points + _bonus;
            _points = $"{addedPoints}";
            IsComplete();

        }
        
    }

    public override void IsComplete()
    {
            _checkbox = "[x]";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_checkbox}|{_amountCompleted}|{_target}|{_bonus}";
    }

    public override string GetDetailsString()
    {
        return $"{_checkbox} {_shortName} ({_description}) -- Currently completed {_amountCompleted}/{_target})";
    }

}


