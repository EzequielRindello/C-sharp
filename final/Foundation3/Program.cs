using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program 3: Inheritance with Event Planning.");
        Console.WriteLine("Hello, please select an event from the following:");
        while (true)
        {
            Console.WriteLine("1: Lectures \n2: Outdoor Gatherings\n3: Receptions\n4: Quit");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.Clear();
                    Event event1 = new Lectures();
                    event1.StandardDetails();
                    break;
                case "2":
                    Console.Clear();
                    Event event2 = new OutdoorGatherings();
                    event2.StandardDetails();
                    break;
                case "3":
                    Console.Clear();
                    Event event3 = new Receptions();
                    event3.StandardDetails();
                    break;
                case "4":
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