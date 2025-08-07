public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"You earned {Points} points!");
    }

    public override string GetStatus()
    {
        return "[∞]";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{Name}|{Description}|{Points}";
    }
}
