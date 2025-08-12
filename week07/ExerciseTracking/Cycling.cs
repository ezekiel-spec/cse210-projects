using System;

public class Cycling : Activity
{
    private double _speedMph;

    public Cycling(DateTime date, int lengthMinutes, double distanceMiles)
        : base(date, lengthMinutes)
    {
        _speedMph = (distanceMiles / lengthMinutes) * 60;
    }

    public override double GetDistance()
    {
        return (_speedMph * LengthMinutes) / 60;
    }

    public override double GetSpeed()
    {
        return _speedMph;
    }

    public override double GetPace()
    {
        return 60 / _speedMph;
    }

    protected override string GetDistanceUnit() => "miles";
    protected override string GetSpeedUnit() => "mph";
    protected override string GetPaceUnit() => "min/mile";
}
