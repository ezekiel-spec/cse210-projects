using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercise Tracking Program");

        // Create a list of Activity objects
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 7, 1), 30, 4.8),   // 4.8 miles
            new Cycling(new DateTime(2024, 7, 2), 45, 15.0), // 15 miles
            new Swimming(new DateTime(2024, 7, 3), 25, 40)   // 40 laps
        };

        // Loop through and display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
