/* Write a program which asks the user to input two integers and then tells which of the numbers is greater or if they are equal.

Example output:
Please input the first number: 
42
Please input the second number: 
42
Numbers are equal.
 */

using System;

class NumberComparison
{
    static void Main()
    {
        int firstNumber;
        int secondNumber;

        Console.WriteLine("Please input the first number:");
        firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please input the second number:");
        secondNumber = Convert.ToInt32(Console.ReadLine());

        if (firstNumber == secondNumber)
        {
            Console.WriteLine("Numbers are equal.");
        }
        else if (firstNumber > secondNumber)
        {
            Console.WriteLine("Number 1 is greater than number 2.");
        }
        else
        {
            Console.WriteLine("Number 2 is greater than number 1.");
        }
    }
}