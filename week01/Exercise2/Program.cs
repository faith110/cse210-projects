using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("what is your grade percentage?");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        string letter = "";
        string sign = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else if (number < 60)
        {
            letter = "F";
        }

        if (number % 10 >= 7 && letter == "A" || letter == "F")
        {
            sign = "";
        }
        else if (number % 10 >= 3)
        {
            sign = "+";
        }
        else if (number % 10 < 3)
        {
            sign = "-";
        }
        Console.WriteLine($"your grade is {letter}{sign}");

        if (number >= 70)
        {
            Console.WriteLine("Congratulations you passed");
        }
        else if (number < 70)
        {
            Console.WriteLine("please do better next time");
        }
    }
}
    