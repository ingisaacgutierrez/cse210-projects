using System;
using System.ComponentModel;

class ListingActivity : Activity
{
    private List<string> _questions = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };
    private List<string> _answers = new List<string>();

    public ListingActivity(string name, string description, int duration)
    :base(name, description, duration)
    {
    }
    Random rnd = new Random();
    
    public void DisplayQuestions()
    {
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($"\n---- {GetRandomQuestions()} ----");
        Console.WriteLine("\nYou may begin in:");
        pauseCountdownTimer(GetDuration()/6);
    }
    
    public string GetRandomQuestions()
    {      
        int rndIn = rnd.Next(_questions.Count);
        return _questions[rndIn];
    }
    public void GetUserAnswer()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while(DateTime.Now < endTime)
        {
            string answer = Console.ReadLine();
            _answers.Add(answer);
            Console.ReadKey();
        }

        Console.WriteLine($"\nYou listed {_answers.Count} items.");
    }
    







}