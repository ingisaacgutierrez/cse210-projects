using System;

class Program
{
    static void Main(string[] args)
    {
        string menuOption = "0";
            do
            {
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
                    Console.WriteLine("Create New Goal");
                        break;
                    case "2":
                    Console.WriteLine("List Goals");
                        break;
                    case "3":
                    Console.WriteLine("Save Goals");
                    break;
                    case "4":
                   Console.WriteLine("Load Goals");
                        break;
                    case "5":
                    Console.WriteLine("Record Event");
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