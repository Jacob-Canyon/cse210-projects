using System.ComponentModel.DataAnnotations;

namespace Develop03;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

//Construtors------------------------------------------------

    public Reference(string book,int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
 

    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

//Method------------------------------------------

    public string GetDiplayText()
    {   string display = "";

        if(_endVerse == 0)
        {
            display = $"{_book} {_chapter}:{_verse} ";
        }
        else
        {
            display = $"{_book} {_chapter}:{_verse}-{_endVerse} ";
        }

        return display;
    }
}
