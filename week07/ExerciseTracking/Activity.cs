using System;

public abstract class Activity
{
    private DateTime _date;
    private int _lengthMinutes;

    public Activity(DateTime date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public DateTime Date => _date;
    public int LengthMinutes => _lengthMinutes;

    // Abstract methods to be implemented by child classes
    public abstract double GetDistance(); // miles for Running/Cycling, km for Swimming
    public abstract double GetSpeed();    // mph or kph
    public abstract double GetPace();     // min per mile or min per km

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_lengthMinutes} min) - " +
               $"Distance: {GetDistance():0.0} {GetDistanceUnit()}, " +
               $"Speed: {GetSpeed():0.0} {GetSpeedUnit()}, " +
               $"Pace: {GetPace():0.0} {GetPaceUnit()}";
    }

    protected abstract string GetDistanceUnit();
    protected abstract string GetSpeedUnit();
    protected abstract string GetPaceUnit();
}
