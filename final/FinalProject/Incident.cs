using System.Collections.Specialized;
using System.Runtime.CompilerServices;

namespace FinalProject;

public class Incident
{
    protected string _date = "";
    protected String _time = "";
    protected String _level = "";
    protected string _descriptionOfEvent = "";
    protected string _location = "";

    List<Incident> _listOfIncidents = new List<Incident>();

    


    public virtual void DisplayDetails()
    {
        Console.WriteLine($"date: {_date} time: {_time} Level: {_level}");
    }

    public virtual string SaveFormat()
    {
        return "";
    }

}
