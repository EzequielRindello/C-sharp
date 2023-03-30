class Program
{
    static void Main(string[] args)
    {
        // Clear the console, create a list of activities, and initialize a variable i to keep track of the count of activities.
        int i = 0;
        Console.Clear();
        List<Activity> activities = new List<Activity>();
        Console.WriteLine("Program 4: Polymorphism with Exercise Tracking.");
        Console.WriteLine();

        // Create some activities and add to the list of activities.
        Running running = new Running("27/3/2023", 30, 3, "Running");
        activities.Add(running);

        Cycling cycling = new Cycling("28/3/2023", 45, 10, 12, "Cycling");
        activities.Add(cycling);

        Swimming swimming = new Swimming("29/3/2023", 60, 25, "Swimming");
        activities.Add(swimming);

        // Iterate through the list of activities.
        foreach (Activity activity in activities)
        {
            i++;
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.Write($"{i}- ");
            Console.WriteLine(activity.GetSummary());
        }

        Console.WriteLine("----------------------------------------------------------------------------------------");
        Console.WriteLine();
    }
}