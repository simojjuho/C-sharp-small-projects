/*
ASSIGNMENT:  Write a C# program which asks the user’s age and then prints out if the user is eligible to cast his/her own vote.
The age limit for casting a vote is 18.

Example output:
Please input your age: 
32
You can cast your vote!
 */

using System;
class ageCheck
{
    static void Main(String[] args)
    {
        byte age;
        Console.WriteLine("Please input your age: ");
        age = Convert.ToByte(Console.ReadLine());

        if(age > 17)
        {
            Console.WriteLine("You can cast your vote!");
        }
        else 
        {
            Console.WriteLine("You're too young!");
        }


        
    }
}