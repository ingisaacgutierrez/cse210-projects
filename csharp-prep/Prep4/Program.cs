using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        

        List<int> numbers;
        numbers = new List<int>();

        int num = -1;

        while (num != 0)
        {
            Console.Write("Enter number: ");
            string entnum = Console.ReadLine();
            num = int.Parse(entnum);
            
            if (num !=0){
            numbers.Add(num);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum)/numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
                if (number > max)
                {
                    max = number;
                }
        }
        Console.WriteLine($"The max is: {max}");


    }
}