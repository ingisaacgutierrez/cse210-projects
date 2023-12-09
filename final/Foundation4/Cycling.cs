using System;

class Cycling : Activity
{
    private double _speed;
    public Cycling(DateTime date, string name, int lengthInMinutes, double speed)
    :base(date, name, lengthInMinutes)
    {
        _speed = speed;
    }
    public override double getDistance()
    {
        return (_speed /60) * getLengthInMinutes();
    }
    public override double getSpeed()
    {
        return _speed;
    }
    public override double getPace()
    {
        return 60 / _speed;
    }
}