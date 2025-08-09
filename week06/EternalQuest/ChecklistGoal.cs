using System;

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _currentCount++;
        Console.WriteLine($"Event recorded for: {GetName()} ({_currentCount}/{_targetCount})");

        if (IsComplete())
        {
            Console.WriteLine($"Goal complete! You earned {_bonus} bonus points!");
        }
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override int GetPoints()
    {
        if (IsComplete())
        {
            return base.GetPoints() + _bonus;
        }
        return base.GetPoints();
    }

    public override string GetDetailsString()
    {
        return $"{GetName()} - {GetDescription()} ({_currentCount}/{_targetCount})";
    }
}
