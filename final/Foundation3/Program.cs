using System;

class Program
{
    static void Main(string[] args)
    {
        // Clear the console, present the program.
        Console.Clear();
        Console.WriteLine("Program 3: Inheritance with Event Planning.");
        Console.WriteLine();
        Console.WriteLine("Hello, please select an event from the following:");

        while (true)
        {
            // Menu and user input to select what objet to create.
            Console.WriteLine("   1: Lectures \n   2: Outdoor Gatherings\n   3: Receptions\n   4: Quit");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.Clear();
                    Event event1 = new Lectures();
                    Console.WriteLine(event1.StandardDetails());
                    event1.ReadKey();
                    break;
                case "2":
                    Console.Clear();
                    Event event2 = new OutdoorGatherings();
                    Console.WriteLine(event2.StandardDetails());
                    event2.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    Event event3 = new Receptions();
                    Console.WriteLine(event3.StandardDetails());
                    event3.ReadKey();
                    break;
                case "4":
                    Console.WriteLine("Thanks for using our program, goodbye!");
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Error. Please enter a valid choice!");
                    Thread.Sleep(3000);
                    break;
            }
        }
    }
}