using System;

public class Cycling : Activity
{
    private double _speed; // in mph

    public Cycling(DateTime date, int duration, double speed)
        : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance() => (_speed * base._duration) / 60; // in miles

    public override double GetSpeed() => _speed;

    public override double GetPace() => 60 / _speed; // min per mile

    public override string GetSummary()
    {
        return base.GetSummary() + $"Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace():F2} min per mile";
    }
}
