using System;

class Comment
{
    public string _commenterName;
    public string _text;

    public void DisplayComment()
    {
        Console.WriteLine($"User: {_commenterName}");
        Console.WriteLine($"Comment: {_text}");
        Console.WriteLine();
    }
    
}