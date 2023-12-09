using System;

class Running : Activity
{
    private double _distance;
    public Running(DateTime date, string name, int lengthInMinutes, double distance)
    :base(date,name ,lengthInMinutes)
    {
        _distance = distance;
    }

    public override double getDistance()
    {
        return _distance;
    }
    public override double getSpeed()
    {
        return (_distance / getLengthInMinutes()) * 60;
    }
    public override double getPace()
    {
        return getLengthInMinutes() / _distance;
    }
}