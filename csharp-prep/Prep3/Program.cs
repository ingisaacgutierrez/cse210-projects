using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicnum = randomGenerator.Next(1, 101);
        
        int gms = -1;
        while (gms != magicnum){
            Console.Write("What is your guess? ");
            gms = int.Parse(Console.ReadLine());

            if (gms > magicnum){
                Console.WriteLine("Lower");
            }
            else if (gms < magicnum){
                Console.WriteLine("Higher");
            }
            else{
                 Console.WriteLine("You guessed it!");
            }
        
        } 
    }
}