using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        Console.Write("what is your first name?");
        string name = Console.ReadLine();
        Console.Write("what is your last name?");
        string surname = Console.ReadLine();
        Console.WriteLine($"Your name is {surname}, {name} {surname}.");
    }
}