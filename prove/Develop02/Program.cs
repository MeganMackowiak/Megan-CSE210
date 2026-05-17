using System;

namespace Develop02;
    class Program
    {
        static void Main(string[] args)
        {
            Journal myJournal = new Journal();
            bool running = true;

            Console.WriteLine("Welcome to your Electronic Journal Program!");

            while (running)
            {
                Console.WriteLine("\nPlease choose one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.Write("What would you like to do? ");
                
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Create a new entry
                        Entry newEntry = new Entry();
                        
                        // Set up automated date capture
                        DateTime theCurrentTime = DateTime.Now;
                        newEntry._date = theCurrentTime.ToShortDateString();
                        
                        // Set up random prompt
                        newEntry._promptText = myJournal.GetRandomPrompt();
                        Console.WriteLine($"\nPrompt: {newEntry._promptText}");
                        Console.Write("> ");
                        newEntry._entryText = Console.ReadLine();

                        // Creative Feature Application: Mood tracking
                        Console.Write("Rate your current mood today (1-5): ");
                        newEntry._moodRating = Console.ReadLine();

                        myJournal.AddEntry(newEntry);
                        break;

                    case "2":
                        myJournal.DisplayAll();
                        break;

                    case "3":
                        Console.Write("What is the filename? ");
                        string loadFile = Console.ReadLine();
                        myJournal.LoadFromFile(loadFile);
                        break;

                    case "4":
                        Console.Write("What is the filename? ");
                        string saveFile = Console.ReadLine();
                        myJournal.SaveToFile(saveFile);
                        break;

                    case "5":
                        running = false;
                        Console.WriteLine("Goodbye! Keep up the habit of writing.");
                        break;

                    default:
                        Console.WriteLine("Invalid entry. Please type a number between 1 and 5.");
                        break;
                }
            }
        }
    }
}