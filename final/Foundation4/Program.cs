using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> act = new List<Activity>();
        Running run = new Running(DateTime.Now, "Running",30, 4.0);
        Cycling cy = new Cycling(DateTime.Now, "Cycling", 60,35);
        Swimming sw = new Swimming(DateTime.Now,"Swimming",30,20);
        act.Add(run);
        act.Add(cy);
        act.Add(sw);
        Console.WriteLine();
        foreach (Activity activity in act)
        {
            Console.WriteLine(activity.getSummary());
        }
        Console.WriteLine();
    }
}