using System;

class Swimming : Activity
{
    private int _numberofLaps;
    public Swimming(DateTime date, string name, int lengthInMinutes, int numberofLaps)
    :base(date, name, lengthInMinutes)
    {
        _numberofLaps = numberofLaps;
    }
     public override double getDistance()
    {
        return (_numberofLaps * 50 / 1000) * 0.62;
    }
    public override double getSpeed()
    {
        return (getDistance() / getLengthInMinutes());
    }
    public override double getPace()
    {
        return getLengthInMinutes() / getDistance();
    }
}