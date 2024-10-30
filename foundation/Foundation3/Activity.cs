using System;

public abstract class Activity
{
    protected DateTime _date;
    protected int _duration; // Duration in minutes

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public virtual double GetDistance() => 0;
    public virtual double GetSpeed() => 0;
    public virtual double GetPace() => 0;

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} Activity ({_duration} min) - ";
    }
}
