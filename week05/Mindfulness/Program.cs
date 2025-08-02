using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");
            string input = Console.ReadLine();

            if (input == "1")
                new BreathingActivity().Run();
            else if (input == "2")
                new ReflectingActivity().Run();
            else if (input == "3")
                new ListingActivity().Run();
            else if (input == "4")
                break;
        }
    }
}
