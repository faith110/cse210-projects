using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal theJournal = new Journal();
        List<string> prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is something new I learned today?",
            "What challenged me today and how did I handle it?"
        };

        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Select an option from the menu: ");

            string input = Console.ReadLine();
            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        Random random = new Random();
                        int index = random.Next(prompts.Count);
                        string prompt = prompts[index];

                        Console.WriteLine($"\nPrompt: {prompt}");
                        Console.Write("> ");
                        string entryText = Console.ReadLine();

                        string date = DateTime.Now.ToShortDateString();
                        Entry newEntry = new Entry(date, prompt, entryText);
                        theJournal.AddEntry(newEntry);
                        Console.WriteLine("Entry added successfully!\n");
                        break;

                    case 2:
                        Console.WriteLine("\n--- Journal Entries ---");
                        theJournal.DisplayJournal();
                        break;

                    case 3:
                        Console.Write("\nEnter filename to save (e.g., journal.txt): ");
                        string saveFile = Console.ReadLine();
                        theJournal.SaveToFile(saveFile);
                        break;

                    case 4:
                        Console.Write("\nEnter filename to load (e.g., journal.txt): ");
                        string loadFile = Console.ReadLine();
                        theJournal.LoadFromFile(loadFile);
                        break;

                    case 5:
                        Console.WriteLine("\nGoodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose between 1 and 5.\n");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.\n");
            }
        }
    }
}
// EXCEEDING REQUIREMENTS DESCRIPTION:
// 1. Added robust input validation using int.TryParse() to prevent program crashes 
//    when users enter invalid menu choices or non-numeric inputs.
// 2. Expanded the prompt list well beyond the minimum requirement with engaging 
//    self-reflection questions.
// 3. Implemented clean error checking during file operations to ensure safe loading.