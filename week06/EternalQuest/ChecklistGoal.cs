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
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            Console.WriteLine($"Event recorded! You have completed this goal {_currentCount}/{_targetCount} times.");
            if (_currentCount == _targetCount)
            {
                Console.WriteLine($"Congratulations! You earned a bonus of {_bonus} points!");
            }
        }
        else
        {
            Console.WriteLine("This goal is already completed.");
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

    public override string GetStatus()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description}) -- Completed {_currentCount}/{_targetCount}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName}|{_description}|{_points}|{_targetCount}|{_bonus}|{_currentCount}";
    }
}
