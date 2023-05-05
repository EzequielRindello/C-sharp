using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int i = 0;
        List<Can> cans = new List<Can>();

        Can first = new Can("#1 Picnic", 6.83, 10.16);
        cans.Add(first);

        Can second = new Can("#2", 8.73, 11.59);
        cans.Add(second);

        Can third = new Can("#2.5", 10.32, 11.91);
        cans.Add(third);

        Can fourth = new Can("#3 Cylinder", 10.79, 17.78);
        cans.Add(fourth);

        Can fifth = new Can("#5", 13.02, 14.29);
        cans.Add(fifth);

        Can sixth = new Can("#6Z", 5.4, 8.89);
        cans.Add(sixth);

        Can seventh = new Can("#8Z short", 6.83, 7.62);
        cans.Add(seventh);

        Can eighth = new Can("#10", 15.72, 17.78);
        cans.Add(eighth);

        Can ninth = new Can("#211", 6.83, 12.38);
        cans.Add(ninth);

        Can tenth = new Can("#300", 7.62, 11.27);
        cans.Add(tenth);

        Can eleventh = new Can("#303", 8.1, 11.11);
        cans.Add(eleventh);

        foreach (Can can in cans)
        {
            i++;
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.Write($"{i}- ");
            Console.WriteLine(can.GetSummary());
        }
    }
}
