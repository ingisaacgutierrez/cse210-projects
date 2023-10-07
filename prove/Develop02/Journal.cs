using System;
using System.IO;
using System.Collections.Generic;


public class Journal 
{
    public List<Entry> _entries = new List<Entry>();
    public string _fileName;
    PromptGenerator rndprompt = new PromptGenerator();

    public void Write()
    {
        string prompt = rndprompt.GivePrompt();
        Console.WriteLine($"\nTell me about:" +
        $"\n{prompt}");
        string response = Console.ReadLine();
        _entries.Add(new Entry {_prompt = prompt, _contentJournal =  response, _date = DateTime.Now.ToString()});
        Console.WriteLine("\nYour entries have been saved");
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
           Console.WriteLine(
           $"\nDate: {entry._date}"+
           $"\nPrompt: {entry._prompt}" +
           $"\nThoughs: {entry._contentJournal}");
        }
    }

    public void LoadFile()
    {
        

        Console.WriteLine("\nPlease enter the name of the File");
        _fileName = Console.ReadLine();
        Console.WriteLine($"\nWe are reading your File...");

        if (File.Exists(_fileName))
        {
           string[] lines = System.IO.File.ReadAllLines(_fileName);
           foreach (string line in lines)
           {
            //Console.WriteLine(line);
            string[] parts = line.Split("~~");

            Entry entry = new Entry();
            Console.WriteLine($"\n{entry._date = parts[0]}");
            Console.WriteLine(entry._prompt = parts[1]);
            Console.WriteLine(entry._contentJournal = parts[2]);   
           }
        }
        else
        {
            Console.WriteLine("\nNo file found to load");
        }
    }

    public void SaveFile()
    {
        Console.WriteLine("\nWrite a name to save your file");
        _fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date: {entry._date}~~Prompt: {entry._prompt}~~Thoughs: {entry._contentJournal}");
            }
        }


    }
    public void Quite()
    {
        Console.WriteLine("\nCome back early! ");
        Environment.Exit(0);
    }
}