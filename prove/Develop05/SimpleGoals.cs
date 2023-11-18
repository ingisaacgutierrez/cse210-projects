using System;
using System.Xml.Serialization;

class SimpleGoals: Goal
{
    public SimpleGoals(string name, string description, int value, bool completed)
    :base(name, description, value, completed)
    {
        
    }

    public override string GetRecord()
    {
        return null;
        
    }
    public override string GetDisplay()
    {
       string status = GetComplete() ? "X" : " ";
       return $"{GetType()}: [{status} ] {GetName()} ({GetDescription()}) Posible points: {GetValue()}";
    }
    public override string GetType()
    {
        return "Simple Goal";
    }
    public override string ListGoal()
    {
       string status = GetComplete() ? "X" : " ";
       return $"{GetType()}:, [{status}],{GetName()},({GetDescription()}),{GetValue()}";
    }
}