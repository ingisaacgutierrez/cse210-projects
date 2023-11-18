using System;


class CreatedGoals
{
    private string _menuOption;

    private List<Goal> _goalsList;
    public CreatedGoals()
    {
        _menuOption = "0";
        _goalsList = new List<Goal>();
    }

    public void GetMenu()
    {
        _menuOption = "0";
            do
            {
               string name;
               string description;
               int value;
                Console.WriteLine("\n" +"The types of Goals are:");
                Console.WriteLine("  1. Simple Goal" +
                    "\n  2. Eternal Goal" +
                    "\n  3. Checklist Goal"
                    );
                Console.WriteLine("\nWhich type of goa would you like to create?: ");
                _menuOption = Console.ReadLine();
                Console.Clear();  
                switch (_menuOption)
                {
                    case "1":
                    Console.WriteLine("What is the name of your goal? ");
                    name = Console.ReadLine();
                    Console.WriteLine("What is a shor description of it? ") ;
                    description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    value = Convert.ToInt32(Console.ReadLine());
                    SimpleGoals sg = new SimpleGoals(name, description, value, false);
                    _goalsList.Add(sg);
                    _menuOption = "0";
                        break;
                    case "2":
                    Console.WriteLine("What is the name of your goal? ");
                    name = Console.ReadLine();
                    Console.WriteLine("What is a shor description of it? ") ;
                    description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    value = Convert.ToInt32(Console.ReadLine());
                    EternalGoals eg = new EternalGoals(name, description, value, false);
                     _goalsList.Add(eg);
                    _menuOption = "0";
                        break;
                    case "3":
                    Console.WriteLine("What is the name of your goal? ");
                    name = Console.ReadLine();
                    Console.WriteLine("What is a shor description of it? ") ;
                    description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    value = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                    int count = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("what is the bonus for accomplishing it that many times? ");
                    int bonus = Convert.ToInt32(Console.ReadLine());
                    CheckListGoals chg = new CheckListGoals(name, description, value, false, count, bonus);
                    _goalsList.Add(chg);
                    _menuOption = "0";
                        break;
                    default:
                        break;
                }
            }
            
            while (_menuOption != "0");     
       
    }

   
    public void GetGoalsList()
    {
        Console.Write("\n");
        for (int i = 0; i < _goalsList.Count(); i++)
        {
            Console.Write($"{i + 1}. ");
            Console.WriteLine(_goalsList[i].ListGoal());
            Console.Write("\n");
        }
    }

      public void ShowGoals()
    {
        Console.Write("\n");
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goalsList.Count(); i++)
        {
            Console.Write($"{i + 1}. ");
            Console.WriteLine(_goalsList[i].GetDisplay());
            Console.Write("\n");
        }
    }

    public void SaveGoals()
    {
        Console.WriteLine("\nWrite a name to save your file");
        string _fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            int _totalPoints = _goalsList.Where(goal => goal.GetComplete()).Sum(goal => goal.GetValue());

            outputFile.WriteLine($"Total Points: {_totalPoints}");
            
            foreach (Goal goal in _goalsList)
            {
                outputFile.WriteLine(goal.ListGoal());
            }
        }
    }


    public void LoadFile()
{
    Console.WriteLine("Enter the name of the file: ");
    string filename = Console.ReadLine();


    
    if (!File.Exists(filename))
    {
        Console.WriteLine($"File {filename} not found!");
        return;
    }

    
    string text;
    try
    {
        text = File.ReadAllText(filename);
    }
    catch (Exception e)
    {
        
        Console.WriteLine($"Error reading file {filename}: {e.Message}");
        return;
    }

    string[] lines = text.Split('\n');
    string _totalPoints = lines[0];

    _goalsList.Clear();

    for (int i= 1; i <lines.Length; i++)
    {
        string [] fields = lines[i].Split(',');
        
        
        if (fields.Length != 8)
        {
            Console.WriteLine($"{lines[i]}");
            continue;
        }

        string type = fields[0];
        bool completed = fields[1] == "[X]";
        string name = fields[2];
        string description = fields[3];
        int value = Convert.ToInt32(fields[4]);
        int count = Convert.ToInt32(fields[6]);
        int bonus = Convert.ToInt32(fields[7]);

        Goal goalLoad;
        if (type == "Simple Goal")
        {
            goalLoad = new SimpleGoals(name, description, value, completed);
        }
        else if (type == "Eternal Goal")
        {
            goalLoad = new EternalGoals(name, description, value, false);
        }
        else if (type == "Checklist Goal")
        {
            goalLoad = new CheckListGoals(name, description, value, false, count, bonus);
        }
        else
        {
            continue;
        }
        _goalsList.Add(goalLoad);

    }

    
    Console.WriteLine($"File {filename} loaded successfully!");
}



}