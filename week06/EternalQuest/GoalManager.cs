using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int totalPoints = 0;

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordGoalEvent(int index)
    {
        if (index >= 0 && index < goals.Count)
        {
            Goal goal = goals[index];
            goal.RecordEvent();

            totalPoints += goal.Points;
            if (goal is ChecklistGoal checklist && checklist.GetStatus().Contains("Bonus"))
            {
                totalPoints += 1000; // example bonus
            }
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()} {goals[i].Name}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total Points: {totalPoints}");
    }
}
