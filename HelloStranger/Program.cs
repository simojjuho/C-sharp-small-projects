// See https://aka.ms/new-console-template for more information

using System;

class HelloStranger
{
    static void Main()
    {
        string answer;
        Console.WriteLine("Hello stranger, state your name!");
        answer = Console.ReadLine();
        Console.WriteLine("Nice to meet you, " + answer + "!");
    }
}