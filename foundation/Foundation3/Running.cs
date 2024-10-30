using System;

public class Running : Activity
{
    private double _distance; // in miles

    public Running(DateTime date, int duration, double distance)
        : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => (_distance / base._duration) * 60; // mph

    public override double GetPace() => base._duration / _distance; // min per mile

    public override string GetSummary()
    {
        return base.GetSummary() + $"Distance: {GetDistance()} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F2} min per mile";
    }
}
