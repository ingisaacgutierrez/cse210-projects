using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        if (int.Parse(grade) >= 90)
        {
            Console.WriteLine($"Your grade is A");
        }
        else if (int.Parse(grade) >= 80)
        {
            Console.WriteLine($"Your grade is B");
        }
        else if (int.Parse(grade) >= 70)
        {
            Console.WriteLine($"Your grade is C");
        } 
        else if (int.Parse(grade) >= 60)
        {
            Console.WriteLine($"Your grade is D");
        } 
        else if (int.Parse(grade) < 600)
        {
            Console.WriteLine($"Your grade is F");
        }

        if ( int.Parse(grade) >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }  
}