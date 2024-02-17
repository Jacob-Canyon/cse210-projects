namespace FinalProject;

public class Incident
{
    protected string _date = "";
    protected String _time = "";
    protected String _level = "";
    protected string _descripitionOfEvent = "";
    protected string _location = "";

    List<Incident> _listOfIncidents = new List<Incident>();


    public Incident (string date, string time, string level)
    {
        _date = date;
        _time = time;
        _level = level;

    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"date: {_date} time: {_time} Level: {_level}");
    }

}
