using System;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void beginMessage()
    {
       Console.WriteLine($"\nWelcome to the {_name}"+$"\n {_description}");
       Console.WriteLine("\nHow long, in seconds, would you like for your session?");

    }
    public void endMessage()
    {
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}");
    }
    public void showingSpinner()
    {
       List<string> spinner = new List<string>();
       spinner.Add("|");
       spinner.Add("/");
       spinner.Add("-");
       spinner.Add("\\");
       spinner.Add("|");
       spinner.Add("/");
       spinner.Add("-");
       spinner.Add("\\");

       DateTime startTime = DateTime.Now;
       DateTime endTime = startTime.AddSeconds(8);

       int i = 0;

       while (DateTime.Now < endTime)
       {
        string s = spinner[i];
        Console.Write(s);
        Thread.Sleep(500);
        Console.Write("\b \b");
        i++;

        if (i>= spinner.Count)
        {
            i = 0 ;
        }
       }
    }
    public void pauseCountdownTimer(int duration)
    {
    
        for (int i=duration; i>0;i--)
        {
            Console.Write(i % 8);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }
    }
}