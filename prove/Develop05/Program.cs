using System;

class Program
{
    static void Main(string[] args)
    { 

        string menuOption = "0";
        CreatedGoals cg = new CreatedGoals();
            do
            {
                Console.WriteLine("You have 0 points");
                Console.WriteLine("\n" +"Menu Options:");
                Console.WriteLine("  1. Create New Goal" +
                    "\n  2. List Goals" +
                    "\n  3. Save Goals" +
                    "\n  4. Load Goals" +
                    "\n  5. Record Event" +
                    "\n  6. Quit"
                    );
                Console.WriteLine("\nSelect a choice from the menu:");
                menuOption = Console.ReadLine();
                Console.Clear();  
                switch (menuOption)
                {
                    case "1":
                    cg.GetMenu();
                        break;
                    case "2":
                    cg.ShowGoals();
                        break;
                    case "3":
                    cg.SaveGoals();
                    break;
                    case "4":
                    cg.LoadFile();
                        break;
                    case "5":
                    Console.WriteLine("Which goal did you accomplish? ");
                    cg.ShowGoals();
                    int index = Convert.ToInt32(Console.ReadLine());
                    break;
                    case "6":
                    Environment.Exit(0);
                    break;
                    default:
                        break;
                }
            }
            
            while (menuOption != "0");        
    }
}