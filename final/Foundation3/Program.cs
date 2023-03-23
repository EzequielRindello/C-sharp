using System;

class Program
{
    static void Main(string[] args)
    {
        // Clear the console, present the program.
        Console.Clear();
        Console.WriteLine("Program 3: Inheritance with Event Planning.");
        Console.WriteLine();

        while (true)
        {
            // Menu and user input to select what objet to create.
            Console.WriteLine("Please select an event from the following:");
            Console.WriteLine("   1: Lectures \n   2: Outdoor Gatherings\n   3: Receptions\n   4: Quit");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    // Creates a lecture objetc.
                    Console.Clear();
                    Lectures event1 = new Lectures();
                    string choice1 = Menu();
                    Console.WriteLine();
                    if (choice1 == "1")
                    {
                        Console.WriteLine(event1.StandardDetails());
                        event1.ReadKey();
                    }
                    else if (choice1 == "2")
                    {
                        event1.LecturesDetails();
                        event1.ReadKey();
                    }
                    else if (choice1 == "3")
                    {
                        Console.WriteLine(event1.ShortDescription());
                        event1.ReadKey();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Error. Please enter a valid choice!");
                        Thread.Sleep(3000);
                    }
                    Console.Clear();
                    break;
                case "2":
                    // Creates a outdoor gathering objetc.
                    Console.Clear();
                    OutdoorGatherings event2 = new OutdoorGatherings();
                    string choice2 = Menu();
                    Console.WriteLine();
                    if (choice2 == "1")
                    {
                        Console.WriteLine(event2.StandardDetails());
                        event2.ReadKey();
                    }
                    else if (choice2 == "2")
                    {
                        event2.OutdoorGatheringsDetails();
                        event2.ReadKey();
                    }
                    else if (choice2 == "3")
                    {
                        Console.WriteLine(event2.ShortDescription());
                        event2.ReadKey();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Error. Please enter a valid choice!");
                        Thread.Sleep(3000);
                    }
                    Console.Clear();
                    break;
                case "3":
                    // Creates a reception objetc.
                    Console.Clear();
                    Receptions event3 = new Receptions();
                    string choice3 = Menu();
                    Console.WriteLine();
                    if (choice3 == "1")
                    {
                        Console.WriteLine(event3.StandardDetails());
                        event3.ReadKey();
                    }
                    else if (choice3 == "2")
                    {
                        event3.ReceptionsDetails();
                        event3.ReadKey();
                    }
                    else if (choice3 == "3")
                    {
                        Console.WriteLine(event3.ShortDescription());
                        event3.ReadKey();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Error. Please enter a valid choice!");
                        Thread.Sleep(3000);
                    }
                    Console.Clear();
                    break;
                case "4":
                    Console.WriteLine("Thanks for using our program, goodbye!");
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Error. Please enter a valid choice!");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
            }
        }
    }

    public static string Menu()
    {
        // Presents the user with a menu and retur and answer to execute the if/else if/else in the switch.
        Console.WriteLine("Select a choice from the following:");
        Console.WriteLine("   1: Standard details \n   2: Full details\n   3: Short description");
        return Console.ReadLine();
    }
}