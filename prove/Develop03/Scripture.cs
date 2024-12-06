using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Scripture 
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] scriptureWords = text.Split(' ');

        
        foreach (string word in scriptureWords)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        _words[numberToHide].Hide();
    }

    public string GetDisplayText()
    {
        
        string displayText = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
           displayText += word.GetDisplayText() + " ";
        }

        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        //check to see if any word is visible
        bool completelyHidden = true;
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                completelyHidden = false;
            }
        }
        return completelyHidden;
    }
}