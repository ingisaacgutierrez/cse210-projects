using System;

class Program
{
    static void Main(string[] args)
    {
       string menuOption = "0";
            do
            {
                Console.WriteLine("\n" +"Menu Options:");
                Console.WriteLine("  1. Start Breathing Activity" +
                    "\n  2. Start Reflecting Activity" +
                    "\n  3. Start Listing Activity" +
                    "\n  4. Quit"
                    );
                Console.WriteLine("Select a choice from the menu:");
                menuOption = Console.ReadLine();
                Console.Clear();  
                switch (menuOption)
                {
                    case "1":
                    BreathingActivity ba = new BreathingActivity("Breathing Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",0);
                    ba.beginMessage();
                    int duration = Convert.ToInt32(Console.ReadLine());
                    BreathingActivity baTime = new BreathingActivity("Breathing Activity", "",duration);
                    Console.Clear();
                    Console.WriteLine("Get ready...");
                    baTime.showingSpinner();
                    baTime.showBreathingActivity();
                    //baTime.pauseCountdownTimer();
                    Console.WriteLine("Well done...");
                    baTime.showingSpinner();
                    baTime.endMessage();
                    baTime.showingSpinner();
                        break;
                    case "2":
                   
                    Console.WriteLine("option2");
                        break;
                    case "3":
                    
                    Console.WriteLine("option3");
                        break;
                    case "4":
                    
                        break;
                    default:
                        break;
                }
            }
            
            while (menuOption != "0");        
    }
}