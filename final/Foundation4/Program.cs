class Program
{
    static void Main(string[] args)
    {
        // Clear the console and create a list of activities
        Console.Clear();
        List<Activity> activities = new List<Activity>();

        // Create some activities and add to the list of activities
        Running running = new Running("27/3/2023", 45, 7);
        activities.Add(running);

        Cycling cycling = new Cycling("28/3/2023", 60, 25);
        activities.Add(cycling);

        Swimming swimming = new Swimming("29/3/2023", 60, 35);
        activities.Add(swimming);

        // Iterate through the list of activities
        foreach (Activity s in activities)
        {
            // Notice that all shapes have a GetColor method from the base class
            //string color = s.GetColor();

            // Notice that all shapes have a GetArea method, but the behavior is
            // different for each type of shape
            //double area = s.GetArea();

            //Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}