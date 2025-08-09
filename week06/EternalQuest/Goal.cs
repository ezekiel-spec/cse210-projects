using System;

public abstract class Goal
{
    private string _name;
    private string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public virtual int GetPoints()
    {
        return _points;
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public abstract void RecordEvent();
    public abstract string GetDetailsString();
}
