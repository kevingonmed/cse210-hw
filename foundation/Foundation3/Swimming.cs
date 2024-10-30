using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int duration, int laps)
        : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance() => (_laps * 50) / 1000.0; // in km

    public override double GetSpeed() => (GetDistance() / base._duration) * 60; // kph

    public override double GetPace() => base._duration / GetDistance(); // min per km

    public override string GetSummary()
    {
        return base.GetSummary() + $"Distance: {GetDistance():F2} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";
    }
}
