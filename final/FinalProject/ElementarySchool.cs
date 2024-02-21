namespace FinalProject;

public class ElementarySchool : Student
{
    string _teacher = "";

    public ElementarySchool (string name, string grade, string id, string teacher)
    {
        _name = name;
        _grade = grade;
        _IDNumber = id;
        _teacher = teacher;
    }

    public override string SaveFormat()
    {
        string saveFormat = $"ElementarySchool|{_IDNumber}|{_name}|{_grade}|{_teacher}|";
        return saveFormat;
    }
}
