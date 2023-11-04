using System;

class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    public ReflectionActivity(string name, string description, int duration)
    :base(name, description,duration)
    {
       
    }
    Random rnd = new Random();
    public void DisplayPrompt()
    {
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n----{GetRandomPrompt()}----");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue");
        Console.ReadKey();
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You may begin in:");
        pauseCountdownTimer(GetDuration()/6);
    }
    public void DisplayQuestion()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        
        Console.Clear();
        while(DateTime.Now < endTime)
        {
            Console.WriteLine($"\n{GetRandomQuestion()}");
            showingSpinner();
            
        }
    }
    public string GetRandomPrompt()
    {
        int rndIn = rnd.Next(_prompts.Count);
        return _prompts[rndIn];
    }
    public string GetRandomQuestion()
    {
        int rndIn = rnd.Next(_questions.Count);
        return _questions[rndIn];
    }









}
