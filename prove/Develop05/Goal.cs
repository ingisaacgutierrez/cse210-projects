using System;



public abstract class Goal
{
    private string _name;
    private string _description;
    private int _value;
    private bool _completed;
    public Goal(string name, string description, int value, bool completed)
    {
        _name = name;
        _description = description;
        _value = value;
        _completed = completed;
       
    }

    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }

    public int GetValue()
    {
        return _value;
    }

    public bool GetComplete()
    {
        return _completed;
    }
   
    public abstract string GetRecord();
    public abstract string GetDisplay();
    public abstract string GetType();
    public abstract string ListGoal();
    

}

