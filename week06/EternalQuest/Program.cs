using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create Simple Goal");
            Console.WriteLine("2. Create Eternal Goal");
            Console.WriteLine("3. Create Checklist Goal");
            Console.WriteLine("4. View Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. View Score");
            Console.WriteLine("7. Quit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Description: ");
                    string desc = Console.ReadLine();
                    Console.Write("Points: ");
                    int pts = int.Parse(Console.ReadLine());
                    manager.AddGoal(new SimpleGoal(name, desc, pts));
                    break;

                case "2":
                    Console.Write("Name: ");
                    string ename = Console.ReadLine();
                    Console.Write("Description: ");
                    string edesc = Console.ReadLine();
                    Console.Write("Points: ");
                    int epts = int.Parse(Console.ReadLine());
                    manager.AddGoal(new EternalGoal(ename, edesc, epts));
                    break;

                case "3":
                    Console.Write("Name: ");
                    string cname = Console.ReadLine();
                    Console.Write("Description: ");
                    string cdesc = Console.ReadLine();
                    Console.Write("Points per completion: ");
                    int cpts = int.Parse(Console.ReadLine());
                    Console.Write("Target count: ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Bonus points: ");
                    int bonus = int.Parse(Console.ReadLine());
                    manager.AddGoal(new ChecklistGoal(cname, cdesc, cpts, target, bonus));
                    break;

                case "4":
                    manager.DisplayGoals();
                    break;

                case "5":
                    manager.DisplayGoals();
                    Console.Write("Enter goal number to record: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordGoalEvent(index);
                    break;

                case "6":
                    manager.DisplayScore();
                    break;

                case "7":
                    return;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}