using System;

class Word
{
   private string _text;
   private bool _hidden;

   public Word(string text)
   {
        _text = text;
        _hidden = false;
   }
   public void Hide()
   {
        _hidden = true;
   }

    public bool isHidden()
    {
        return _hidden;
    }

    public string GetRenderedText()
    {
        if (_hidden)
        {
           return new string('_', _text.Length);
        }
        return _text;
    
    }

}