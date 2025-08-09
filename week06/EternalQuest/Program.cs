using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();

        // Create some sample goals
        goals.Add(new SimpleGoal("Read Book", "Read 20 pages", 50));
        goals.Add(new EternalGoal("Daily Prayer", "Pray every morning", 10));
        goals.Add(new ChecklistGoal("Exercise", "Workout sessions", 30, 5, 100));

        // Simulate recording events
        goals[0].RecordEvent(); // SimpleGoal
        goals[1].RecordEvent(); // EternalGoal
        goals[2].RecordEvent(); // ChecklistGoal
        goals[2].RecordEvent();
        goals[2].RecordEvent();
        goals[2].RecordEvent();
        goals[2].RecordEvent(); // Should complete

        // Show goal details
        Console.WriteLine("\n--- Goal Summary ---");
        foreach (Goal g in goals)
        {
            Console.WriteLine(g.GetDetailsString());
        }
    }
}