/* 
Write a program which prompts the user for a point in x-y coordinate system and determines in 
which quardant the coordinate point is located or notifies the user if the point lies on origin.

Example output:
Find the quadrant for a point in x-y axis:
X coordinate: 0
Y coordinate: 0
The coordinate point (0,0) is at the origin.
 */

using System;

class Coordinates
{
    static void Main()
    {
        int coordinate1;
        int coordinate2;

        Console.WriteLine("Find the quadrant for a point in x-y axis:");
        Console.Write("X coordinate: ");
        coordinate1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Y coordinate: ");
        coordinate2 = Convert.ToInt32(Console.ReadLine());

        if (coordinate1 == 0 && coordinate2 == 0)
        {
            Console.WriteLine("The coordinate point (" + coordinate1 + "," + coordinate2 + ") is at the origin.");
        }
        else if (coordinate1 >= 0 && coordinate2 >= 0)
        {
            Console.WriteLine("The coordinate point (" + coordinate1 + "," + coordinate2 + ") is in the First quandrant.");   
        }
        else if (coordinate1 <= 0 && coordinate2 >= 0)
        {
            Console.WriteLine("The coordinate point (" + coordinate1 + "," + coordinate2 + ") is in the Second quandrant.");   
        }
        else if (coordinate1 <= 0 && coordinate2 <= 0)
        {
            Console.WriteLine("The coordinate point (" + coordinate1 + "," + coordinate2 + ") is in the Third quandrant.");   
        }
        else
        {
            Console.WriteLine("The coordinate point (" + coordinate1 + "," + coordinate2 + ") is in the Fourth quandrant.");   
        }
    }
}