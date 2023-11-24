using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args) // ejercicios de FreeCodeCamp
    {
        Console.Clear();



        //---------------------------------------------------------------------------------------------------------------------
        // int amount =10;
        // int bonus = amount == 100? 10: 5;
        // Console.WriteLine(bonus);

        //---------------------------------------------------------------------------------------------------------------------
        // Random rd = new();
        // int coin=rd.Next(1,11);
        // string result= coin >= 5? "heads":"tails";
        // Console.WriteLine(coin);
        // Console.WriteLine(result);
        //     string permission = "Admin|Manager";
        //     int level = 53;

        //     if (permission.Contains("Admin"))
        //     {
        //         if (level > 55)
        //         {
        //             Console.WriteLine("Welcome, Super Admin user.");
        //         }
        //         else
        //         {
        //             Console.WriteLine("Welcome, Admin user.");
        //         }
        //     }
        //     else if (permission.Contains("Manager"))
        //     {
        //         if (level >= 20)
        //         {
        //             Console.WriteLine("Contact an Admin for access.");
        //         }
        //         else
        //         {
        //             Console.WriteLine("You do not have sufficient privileges.");
        //         }
        //     }
        //     else
        //     {
        //         Console.WriteLine("You do not have sufficient privileges.");
        //     }
        // }

        //---------------------------------------------------------------------------------------------------------------------
        // int[] numbers = { 4, 8, 15, 16, 23, 42 };
        // bool found = false;
        // int total = 0;
        // foreach (int number in numbers)
        // {

        //     total += number;

        //     if (number == 42)
        //     {
        //         found = true;
        //     }

        // }

        // if (found)
        // {
        //     Console.WriteLine("Set contains 42");

        // }

        // Console.WriteLine($"Total: {total}");


        //---------------------------------------------------------------------------------------------------------------------
        // SKU = Stock Keeping Unit. 
        // SKU value format: <product #>-<2-letter color code>-<size code>
        // string sku = "01-MN-L";

        // string[] product = sku.Split('-');
        // string color;
        // string size;
        // string type;

        // if (product[0] == "01")
        // {
        //     type = "Sweat shirt";
        // }
        // else if (product[0] == "02")
        // {
        //     type = "T-Shirt";
        // }
        // else if (product[0] == "03")
        // {
        //     type = "Sweat pants";
        // }
        // else
        // {
        //     type = "Other";
        // }

        // if (product[1] == "BL")
        // {
        //     color = "Black";
        // }
        // else if (product[1] == "MN")
        // {
        //     color = "Maroon";
        // }
        // else
        // {
        //     color = "White";
        // }

        // if (product[2] == "S")
        // {
        //     size = "Small";
        // }
        // else if (product[2] == "M")
        // {
        //     size = "Medium";
        // }
        // else if (product[2] == "L")
        // {
        //     size = "Large";
        // }
        // else
        // {
        //     size = "One Size Fits All";
        // }

        // Console.WriteLine($"Product: {size} {color} {type}");

        //---------------------------------------------------------------------------------------------------------------------
        // for (int i = 1; i < 101; i++)
        // {
        //     if ((i % 3 == 0) && (i % 5 == 0))
        //         Console.WriteLine($"{i} - FizzBuzz");
        //     else if (i % 3 == 0)
        //         Console.WriteLine($"{i} - Fizz");
        //     else if (i % 5 == 0)
        //         Console.WriteLine($"{i} - Buzz");
        //     else
        //         Console.WriteLine($"{i}");
        // }


        //---------------------------------------------------------------------------------------------------------------------

        // int i = 0;
        // while (true)
        // {
        //     i++;
        //     Console.WriteLine(i);
        //     if (i == 10)
        //     {
        //         break;
        //     }
        // }

        // for (i = 11; i <= 20; i++)
        // {
        //     Console.WriteLine(i);
        // }
        //---------------------------------------------------------------------------------------------------------------------

        // int hero = 10;
        // int monster = 10;
        // // agregar para que el usuario elija la dificultad
        // Random dice = new();

        // do
        // {
        //     int roll = dice.Next(1, 11);
        //     monster -= roll;
        //     Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

        //     if (monster <= 0) continue;

        //     roll = dice.Next(1, 11);
        //     hero -= roll;
        //     Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

        // } while (hero > 0 && monster > 0);

        // Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

        //---------------------------------------------------------------------------------------------------------------------
        // string? readResult;
        // string valueEntered = "";
        // int numValue = 0;
        // bool validNumber = false;

        // Console.WriteLine("Enter an integer value between 5 and 10");

        // do
        // {
        //     readResult = Console.ReadLine();
        //     if (readResult != null)
        //     {
        //         valueEntered = readResult;
        //     }

        //     validNumber = int.TryParse(valueEntered, out numValue);

        //     if (validNumber == true)
        //     {
        //         if (numValue <= 5 || numValue >= 10)
        //         {
        //             validNumber = false;
        //             Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        //         }
        //     }
        //     else
        //     {
        //         Console.WriteLine("Sorry, you entered an invalid number, please try again");
        //     }
        // } while (validNumber == false);

        // Console.WriteLine($"Your input value ({numValue}) has been accepted.");

        // readResult = Console.ReadLine();

        // string? readResult;
        // string roleName = "";
        // bool validEntry = false;

        // do
        // {
        //     Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
        //     readResult = Console.ReadLine();
        //     if (readResult != null)
        //     {
        //         roleName = readResult.Trim();
        //     }

        //     if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
        //     {
        //         validEntry = true;
        //     }
        //     else
        //     {
        //         Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
        //     }

        // } while (validEntry == false);

        // Console.WriteLine($"Your input value ({roleName}) has been accepted.");
        // readResult = Console.ReadLine();
        //---------------------------------------------------------------------------------------------------------------------

    }
}
