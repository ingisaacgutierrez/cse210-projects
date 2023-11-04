using System;


class BreathingActivity : Activity
{
    private string _showBreathIn = "Breathe in...";
    private string _showBreathOut = "Breathe out...";

    public BreathingActivity(string name, string description, int duration)
    :base(name, description, duration)
    {
    }
    public void showBreathingActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        bool isBreathIn = true;

        while (DateTime.Now < endTime)
        {
          if (isBreathIn)
          {
            Console.WriteLine($"\n{_showBreathIn}");
            pauseCountdownTimer(GetDuration()/7);
            isBreathIn = false;
          }
          else
          {
            Console.WriteLine(_showBreathOut);
            pauseCountdownTimer(GetDuration()/5);
            isBreathIn = true;
          }
        }
        
    }
    

}