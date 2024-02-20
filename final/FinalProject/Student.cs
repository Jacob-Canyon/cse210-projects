namespace FinalProject;

public class Student
{
    protected string _name = "";
    protected string _grade = "";
    protected string _IDNumber = "";


    public virtual void DisplayInfo()
    {

    }

    public virtual string SaveFormat()
    {
        return "";
    }
    
    public string GetName()
    {
        string name = _name;
        return name;
    }

    public string GetIDNumber()
    {
        string ID = _IDNumber;
        return ID;
    }

}
