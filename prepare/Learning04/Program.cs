using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennet" , "Multiplicaction");
        Console.WriteLine(assignment.GetSummary());
       
        Console.WriteLine();

        MathAssignment ma1 = new MathAssignment("7.3","8-19", "Roberto Rodriguez","Fractions");
        Console.WriteLine(ma1.GetSummary());
        Console.WriteLine(ma1.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment wa = new WritingAssignment("The causes of Wolrd War II by Mary Waters", "Mary Waters", "European History");
        Console.WriteLine(wa.GetSummary());
        Console.WriteLine(wa.GetWritingInformation());

        Console.WriteLine();

        
    }
}