class Program
{
    static void Main(string[] args)
    {
        // Clear the console and create a list of activities
        Console.Clear();
        int i = 0;
        List<Activity> activities = new List<Activity>();
        Console.WriteLine("Program 4: Polymorphism with Exercise Tracking.");
        Console.WriteLine();

        // Create some activities and add to the list of activities
        Running running = new Running("27/3/2023", 30, 3, "Running");
        activities.Add(running);

        Cycling cycling = new Cycling("28/3/2023", 60, 25, "Cycling");
        activities.Add(cycling);

        Swimming swimming = new Swimming("29/3/2023", 60, 35, "Swimming");
        activities.Add(swimming);

        // Iterate through the list of activities
        foreach (Activity activity in activities)
        {
            i++;
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.Write($"{i}- ");
            Console.WriteLine(activity.GetSummary());
        }
    }
}