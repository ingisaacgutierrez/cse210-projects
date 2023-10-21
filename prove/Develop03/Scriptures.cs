using System;
using System.Diagnostics.Contracts;
using System.Xml.XPath;


class Scriptures
{
    private Reference _reference;
    private List<Word> _words;
    public Scriptures(string text, Reference reference)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public void HideWords()
    {
        Random random = new Random();
        int numWordstoHide = ((Convert.ToInt32(_words.Count)) * 10) /100;

        for (int i = 0; i <numWordstoHide; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }

    }
    public string GetRenderedText()
    {
        string renderedText = " ";
        foreach (Word word in _words)
        {
            renderedText += word.GetRenderedText() + " ";
        }
        return renderedText;
    }
    public bool allHidden()
    {
        foreach(Word word in _words)
        {
            if (!word.isHidden())
            {
                return false;
            }
        }
        return true;
    }


}