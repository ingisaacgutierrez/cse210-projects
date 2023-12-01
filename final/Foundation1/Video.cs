using System;

class Video
{
    public string _title;
    public string _author;
    public string _length;
    public List<Comment> _comment = new List<Comment>();
    public List<string> _video = new List<string>();

     public void DisplayVideoInformation()
    {
        Console.WriteLine();
        Console.WriteLine("-------------- NEW YouTube Video ------------------");
        Console.WriteLine();
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {GetTotalSeconds()}");
        Console.WriteLine($"Number of comments: {_comment.Count()}");
        Console.WriteLine();

        
        foreach (Comment comment in _comment)
        {
            
            comment.DisplayComment();
            
        }
    }

    public int GetTotalSeconds()
    {
        var timeParts = _length.Split(':');
        var minutes = int.Parse(timeParts[0]);
        var seconds = int.Parse(timeParts[1]);
        return (minutes * 60) + seconds;

    }
    

}

