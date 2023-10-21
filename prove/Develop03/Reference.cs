using System;

class Reference
{
   private string _book;
   private int _chapter;
   private int _beginVerse;
   private int _lastVerse;

    public Reference(string  book, int chapter, int beginVerse, int lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _beginVerse = beginVerse;
        _lastVerse = lastVerse;
    

        if (_lastVerse  == 0)
        {
            _lastVerse = _beginVerse;
        }
        else
        {
            _lastVerse = lastVerse;
        }
    }
 
    public string GetReference()
    {
        if(_lastVerse == _beginVerse)
        {
            return $"{_book} {_chapter}: {_beginVerse}";
        }
        else
        {
            return $"{_book} {_chapter}: {_beginVerse}-{_lastVerse}";
        }
    }

    
}