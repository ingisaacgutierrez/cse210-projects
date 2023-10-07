using System;
using System.IO;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        int numMenu = 1;
        string passwordLogin = "5932";
        string userKey;
        string userName;
        Journal journal = new Journal();

        Console.WriteLine("\n   Brigham Young Idaho - University");
        Console.WriteLine("           Course: CSE210       \n");

        Console.WriteLine("          Journal Program           ");
        Console.WriteLine("            Presented by            ");
        Console.WriteLine("          Isaac Gutierrez           ");
        Console.WriteLine("------------------------------------");
        
        do 
        {
            Console.WriteLine("\nProve that you are not a robot, write the following number: (5932)"
            + $"\nyou have 3 attempts (Attempt No.{numMenu})");
            userKey = Console.ReadLine();
            Console.WriteLine("\nWhats your name?");
            userName = Console.ReadLine();
            if (userKey == passwordLogin)   
            {
                string menuOption = "0";

            do
            {
                
                Console.WriteLine($"\n************** Welcome {userName} to your Journal **************");
                
                Console.WriteLine("\n" +
                    "\n1. Write" +
                    "\n2. Display" +
                    "\n3. Save" +
                    "\n4. Load" +
                    "\n5. Quit"
                    );
                Console.WriteLine("Please select one of the following number of choices");
                menuOption = Console.ReadLine();
                
                
                
                switch (menuOption)
                {
                    case "1":
                        journal.Write();

                        break;
                    case "2":
                        journal.Display();
                        break;
                    case "3":
                        journal.SaveFile();
                        Console.WriteLine($"{userName} We are saving your thoughs...");
                        break;
                    case "4":
                        journal.LoadFile();
                        
                        break;
                    case "5":
                        journal.Quite();
                        break;
                    default:
                        Console.WriteLine("\nChoose a valid number between 1 -5, try again");
                        break;

                }
            }
            while (menuOption != "0");
                break;
            }
            else
            {
                numMenu++;
                Console.WriteLine("--------- Incorrect password ---------");
            }


        } 
        while(numMenu <= 3);

            



    }

  
}