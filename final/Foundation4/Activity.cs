using System;
abstract class Activity
{
    private DateTime _date;
    private string _name;
    private int _lengthInMinutes;
    public Activity(DateTime date, string name, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
        _name = name;
    }
    public DateTime getDate()
    {
        return _date;
    }
    public int getLengthInMinutes()
    {
        return _lengthInMinutes;
    }
    public string getName()
    {
        return _name;
    }
    public abstract double getDistance();
    public abstract double getSpeed();
    public abstract double getPace();
    public virtual string getSummary()
    {
        return $"{getDate():dd MMM yyyy} {getName()} ({getLengthInMinutes()} min) - Distance: {Math.Round(getDistance(), 2)} miles, Speed: {Math.Round(getSpeed(), 2)} mph, Pace: {Math.Round(getPace(),2)} min per mile";
    }
    
}