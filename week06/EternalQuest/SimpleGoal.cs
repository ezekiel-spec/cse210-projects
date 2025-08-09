using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Goal '{GetName()}' completed! You earned {GetPoints()} points.");
        }
        else
        {
            Console.WriteLine($"Goal '{GetName()}' is already complete.");
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"{GetName()} - {GetDescription()} (Completed: {_isComplete})";
    }
}
