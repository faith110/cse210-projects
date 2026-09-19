using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        List<Scripture> scriptureLibrary = new List<Scripture>()
        {
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding"
            ),
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life"
            ),
            new Scripture(
                new Reference("Mosiah", 2, 17),
                "When ye are in the service of your fellow beings ye are only in the service of your God"
            )
        };

        // Pick a random scripture from the library
        Random random = new Random();
        Scripture scripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

        string userInput = "";

        while (userInput.ToLower() != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Excellent job memorizing!");
                break;
            }

            Console.Write("Press Enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit")
            {
                scripture.HideRandomWords(3); // Hide 3 words at each step
            }
        }

        Console.WriteLine("\nGoodbye!");
    }
}
// EXCEEDING REQUIREMENTS DESCRIPTION:
// 1. Implemented a scripture library containing multiple scriptures (both single 
//    verses and verse ranges) so a random scripture is chosen each time the program runs.
// 2. Enhanced word-hiding logic to strictly select random words from the pool of 
//    currently visible (unhidden) words, preventing redundant selections on already hidden words.