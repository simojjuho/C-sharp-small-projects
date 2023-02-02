/* Your task is to write a C# program which prints a menu and asks the user for input.
You must use the switch statement. The menu and output should look the following:

Please select:
1) Water
2) Juice
3) Lemonade
4) Quit
2
You selected Juice.

Example output:
Please select:
1) Water
2) Juice
3) Lemonade
4) Quit
4
Quit! */


using System;
class ChooseDrink
{
    static void Main()
    {
        Console.WriteLine("Please select:" + Environment.NewLine + "1) Water");
        Console.WriteLine("2) Juice" + Environment.NewLine + "3) Lemonade" + Environment.NewLine + "4) Quit");

        byte choice;
        choice = Convert.ToByte(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("You selected Water.");
                break;
            case 2:
                Console.WriteLine("You selected Juice.");
                break;
            case 3:
                Console.WriteLine("You selected Lemonade.");
                break;
            case 4:
                Console.WriteLine("Quit!");
                break;
            default:
                Console.WriteLine("Invalid selection.");
                break;
        }
    }
}