namespace Develop03;

public class Word
{
    private string _text = "";
    private bool _isHidden = false;

//Constructors------------------------------------------------

    public Word(string Word)
    {
        _text = Word;
    }


//Methods-----------------------------------------------------

    public void Hide()
    {
        _isHidden = true;
    }

    public string GetDiplayText()
    {
        string wordDisplay = "";
        
        if(_isHidden == false)
        {
            wordDisplay = "" + _text;
        }

        else{
            wordDisplay = " ____";
        }
        
        return wordDisplay;
    }



   


}
