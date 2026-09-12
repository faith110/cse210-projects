using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            Console.Write("what is your guess?");
            string guess = Console.ReadLine();
            int value = int.Parse(guess);
            
            int guessCount = 1;

            while (value != number)
            {
                if (value < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (value > number)
                {
                    Console.WriteLine("Lower");
                }
                Console.Write("What is your guess? ");
                guess = Console.ReadLine();
                value = int.Parse(guess);
                guessCount++;
                if (value == number)
                {
                    Console.WriteLine("Congratulations! You guessed the number!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }
            Console.Write("Do you want to play again? (yes/no) ");
            string playAgain = Console.ReadLine();
            if (playAgain != "yes")
                {
                    break;
                }

        }
    }
}
