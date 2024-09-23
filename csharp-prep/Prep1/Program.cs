using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        String Last = Console.ReadLine();

        Console.Write($"Your name is {Last},{first} {Last} ");
        
    }
}