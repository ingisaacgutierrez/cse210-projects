using System;


public class PromptGenerator
{
    
    public List<string> _pG = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is one thing I could have done differently today",
        "How am I feeling right now",
        "Did I step out of my comfort zone today? How?",
        "What was my favorite scripture today?",
        "Write something you would like to do tomorrow",

    };
    Random rnd = new Random();
    public string GivePrompt()
    {
        int rndIn = rnd.Next(_pG.Count);
        return _pG[rndIn];
    }
}