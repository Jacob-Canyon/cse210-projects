namespace Learning04;

public class MathAssignment : Assignment
{
    string _textBookSection = "";
    string _problems = "";


    public MathAssignment(string studentName, string topic,string textBook, string problems) : base(studentName,topic)
    {
        _problems = problems;
        _textBookSection = textBook;
    }

    public string GetHomeworkAssignment()
    {
        return $"{_studentName} - {_topic}  {_textBookSection} - {_problems}";
    }

}
