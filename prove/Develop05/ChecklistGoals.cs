using System;

class CheckListGoals : Goal
{
    private int _count;
    private int _bonus;
    public CheckListGoals(string name, string description, int value, bool completed, int count, int bonus)
    :base(name, description, value, completed)
    {
        _count = count;
        _bonus = bonus;
    }

    public int GetCount()
    {
        return _count;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public override string GetRecord()
    {
        return null;
    }
    public override string GetDisplay()
    {
       string status = GetComplete() ? "X" : " ";
       return $"{GetType()}: [{status} ] {GetName()} ({GetDescription()}) -- Currently completed: {GetRecord()}/{_count} Posible points: {GetValue()} Possible bonus: {_bonus}";
    }
    public override string GetType()
    {
        return "Checklist Goal";
    }
     public override string ListGoal()
    {
       string status = GetComplete() ? "X" : " ";
       return $"{GetType()}:, [{status}],{GetName()},({GetDescription()}),{GetRecord()},{_count},{GetValue()},{_bonus}";
    }


}