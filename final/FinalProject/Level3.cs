namespace FinalProject;

public class Level3 : Incident
{
    string _lengthOfSuspention = "";
    string _admin = "";

    public Level3(string time, string level, string description, string location, string admin, string suspention, string date)
    {
        _time = time;
        _level = level;
        _descriptionOfEvent = description;
        _location = location;
        _lengthOfSuspention = suspention;
        _admin = admin;
        _date = date;

    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Date: {_date} Time: {_time} Level: {_level} Location: {_location} Admin assigned: {_admin} Length of Suspention in days: {_lengthOfSuspention}\n Description: {_descriptionOfEvent}");
    }

     public override string SaveFormat()
    {
        string saveFormat = $"{_time}|{_level}|{_descriptionOfEvent}|{_location}|{_admin}|{_lengthOfSuspention}|{_date}";
        return saveFormat;
    }
}
