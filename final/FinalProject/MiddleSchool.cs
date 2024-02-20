namespace FinalProject;

public class MiddleSchool : Student
{
    string _homeroom = "";

    public MiddleSchool(string name, string grade, string id, string teacher)
    {
        _name = name;
        _grade = grade;
        _IDNumber = id;
        _homeroom = teacher;
    }

    public override string SaveFormat()
    {
        string saveFormat = $"ElementarySchool|{_IDNumber}|{_name}|{_grade}|{_homeroom}|";
        return saveFormat;
    }


    public override void DisplayInfo()
    {

    }
}
