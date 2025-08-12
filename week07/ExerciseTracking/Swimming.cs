using System;

public class Swimming : Activity
{
    private double _laps;
    private const double LapLengthKm = 50.0 / 1000; // 50 meters in km

    public Swimming(DateTime date, int lengthMinutes, double laps)
        : base(date, lengthMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * LapLengthKm;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / LengthMinutes) * 60;
    }

    public override double GetPace()
    {
        return LengthMinutes / GetDistance();
    }

    protected override string GetDistanceUnit() => "km";
    protected override string GetSpeedUnit() => "kph";
    protected override string GetPaceUnit() => "min/km";
}
