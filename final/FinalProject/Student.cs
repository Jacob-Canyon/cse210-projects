namespace FinalProject;

public class Student
{
    string _name = "";
    string _grade = "";
    string _IDNumber = "";

    public virtual void AddIncident()
    {

    }

    public virtual void DisplayInfo()
    {

    }
    
    public string GetName()
    {
        string name = _name;
        return name;
    }
}
