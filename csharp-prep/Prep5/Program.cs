using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string name = DisName();
        int number = DisNum();

        int sqresult = SqNumber(number);

        DisplayResult(name, sqresult);

    }
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string DisName()
    {            
        Console.Write("Please enter your name: ");
        string username = Console.ReadLine(); 

        return username;
    }
    static int DisNum()
    {
        Console.Write("Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());

        return num;

    }
    static int SqNumber(int num)
    {
        int square = num * num;
        return square;

    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}