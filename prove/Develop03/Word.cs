using System.Runtime.CompilerServices;

public class Word
{

    private string _text;
    private bool _isHidden; 

   public Word (string text)
   {
        _text = text;
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
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden == true)
        {
            string replacement = "";
            foreach (char c in _text)
            {
                replacement.Append('_');
            }
            return replacement;
        }
        else 
        {
            return _text;
        }
    }


}