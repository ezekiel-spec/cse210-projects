using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Progress recorded for '{GetName()}'. You earned {GetPoints()} points.");
    }

    public override string GetDetailsString()
    {
        return $"{GetName()} - {GetDescription()} (Never complete)";
    }
}
