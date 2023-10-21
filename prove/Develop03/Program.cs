using System;
using System.Collections;
using System.Net.Quic;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        string option;
        string numOption;
        Reference ref1 = new Reference("John",3,16,0);
        Scriptures scr1 = new Scriptures("For God so bloved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have heverlasting life.", ref1);
          
        Reference ref2 = new Reference("Proverbs",3,5,6);
        Scriptures scr2 = new Scriptures("Trust in the Lord with all thine heart; and lean not unto thine cown understanding. In all thy ways aacknowledge him, and he shall direct thy paths.",ref2);
        
        Console.Clear();

        Console.WriteLine("Welcome to Scripture Memorizer");
        Console.WriteLine("Please choose one scripture 1.- John 3:16 ; 2.- Proverbs 3:5-6");
        Console.WriteLine("Type 1 or 2");
        numOption = Console.ReadLine();

        if (numOption == "1")
        {
            Console.WriteLine(ref1.GetReference());
            Console.WriteLine(scr1.GetRenderedText());
       
            Console.WriteLine("Press enter to continue or type quit to exit");
            option = Console.ReadLine();
            while(option != "quit" && !scr1.allHidden())
            {
                scr1.HideWords();

                Console.Clear();
                Console.WriteLine(ref1.GetReference());
                Console.WriteLine(scr1.GetRenderedText());

                Console.WriteLine("Press enter to continue or type quit to exit");
                option = Console.ReadLine();
            }
        }
        else{
            Console.WriteLine(ref2.GetReference());
            Console.WriteLine(scr2.GetRenderedText());
        
            Console.WriteLine("Press enter to continue or type quit to exit");
            option = Console.ReadLine();
            while(option != "quit" && !scr2.allHidden())
            {
                scr2.HideWords();

                Console.Clear();
                Console.WriteLine(ref2.GetReference());
                Console.WriteLine(scr2.GetRenderedText());

                Console.WriteLine("Press enter to continue or type quit to exit");
                option = Console.ReadLine();
            }
        } 
           
        Console.WriteLine("Congrats, you have memorized the scripture");
        Environment.Exit(0);
    }
}