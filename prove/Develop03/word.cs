//Word class will contain the word. IF the word is hidden, GetWordString
//Will return _ char - one for each character in the word 

class Word
{
    private string _word;

    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

//GetWordString - Return either the word, if not hidden, or the _s
    public string GetWordString()
    {
        string tempWord = "";
        if (_hidden)
        {
            foreach(char c in _word)
            {
                tempWord += '_';
            }
        }
        else
        {
            tempWord = _word;
        }
        return tempWord;
        
    }


    public void Hide()
    {
        _hidden = true;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public void DisplayWord()
    {
        Console.WriteLine(GetWordString());
    }
}