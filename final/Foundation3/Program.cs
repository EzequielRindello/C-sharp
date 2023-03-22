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
                    // Creates a lecture objetc.
                    Console.Clear();
                    Lectures event1 = new Lectures();
                    string choice1 = Menu();
                    if (choice1 == "1")
                    {
                        Console.WriteLine(event1.StandardDetails());
                    }
                    else if (choice1 == "2")
                    {
                        event1.LecturesDetails();
                    }
                    else
                    {
                        Console.WriteLine(event1.ShortDescription());
                    }
                    event1.ReadKey();
                    break;
                case "2":
                    // Creates a outdoor gathering objetc.
                    Console.Clear();
                    OutdoorGatherings event2 = new OutdoorGatherings();
                    string choice2 = Menu();
                    if (choice2 == "1")
                    {
                        Console.WriteLine(event2.StandardDetails());
                    }
                    else if (choice2 == "2")
                    {
                        event2.OutdoorGatheringsDetails();
                    }
                    else
                    {
                        Console.WriteLine(event2.ShortDescription());
                    }
                    event2.ReadKey();
                    break;
                case "3":
                    // Creates a reception objetc.
                    Console.Clear();
                    Receptions event3 = new Receptions();
                    string choice3 = Menu();
                    if (choice3 == "1")
                    {
                        Console.WriteLine(event3.StandardDetails());
                    }
                    else if (choice3 == "2")
                    {
                        event3.ReceptionsDetails();
                    }
                    else
                    {
                        Console.WriteLine(event3.ShortDescription());
                    }
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

    public static string Menu()
    {
        // Presents the user with a menu and retur and answer to execute the if/else if/else in the switch.
        Console.WriteLine("Select an event from the following:");
        Console.WriteLine("   1: Standard details \n   2: Full details\n   3: Short description");
        return Console.ReadLine();
    }
}