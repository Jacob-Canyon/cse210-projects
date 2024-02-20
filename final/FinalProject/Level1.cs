namespace FinalProject;

public class Level1 : Incident
{
    string _actionTaken = "";
    string _guardianContacted = "";

    public Level1(string time, string level, string description, string location, string actionTaken, string guardian, string date)
    {
        _time = time;
        _level = level;
        _descriptionOfEvent = description;
        _location = location;
        _actionTaken = actionTaken;
        _guardianContacted = guardian;
        _date = date;
    }



    public override void DisplayDetails()
    { 
    
        Console.WriteLine($"Date: {_date} Time: {_time} Level: {_level} Location: {_location} Action Taken: {_actionTaken} Name of Guardian Contacted: {_guardianContacted}\n Description: {_descriptionOfEvent}");
    }

    public override string SaveFormat()
    {
        string saveFormat = $"{_time}|{_level}|{_descriptionOfEvent}|{_location}|{_actionTaken}|{_guardianContacted}|{_date}";
        return saveFormat;
    }
}


