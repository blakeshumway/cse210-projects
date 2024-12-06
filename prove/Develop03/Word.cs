public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        if (_isHidden == false)
        {
            return false;
        }
        else 
        {
            return true;
        }
    }

    public string GetDisplayText()
    {
        if (_isHidden == false)
        {
            return _text;
        }
        else
        {
            int letters = _text.Length;

            string hiddenWord = "";

            while (letters > 0)
            {
                hiddenWord += "_";
                letters -= 1;
            }

            return hiddenWord;

        }
    }
}