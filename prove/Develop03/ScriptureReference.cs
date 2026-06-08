using System.Globalization;
using System.Reflection.Metadata.Ecma335;

class Scripture
{
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    private int NumberOfUnhidden_words()
   
   
   
   
   
    {
      number++;
    }
    
    return number;
    
    private List<Word> ConvertToWords(string text)
    {
        List<Word> words = new List<Word>();

        foreach(string word in text.Split(' '))
        {
            Word tempWord = new Word(word);
            words.Add(tempWord);
            tempWord.HideWord(false);
        }
        return words;

    }

    public bool HideSome_words()
    {
        int numberOfRemaining_words = NumberOfUnhidden_words();
        if (numberOfRemaining_words <= 0)
        {
            
        }
    }
}
