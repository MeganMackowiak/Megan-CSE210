using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        Scripture sr1 = new Scripture(
            new Reference("John", 3, 17),
            "For God sent not his Son into the world to condemn the world; but that the world through him might be saved."
        );

        Scripture sr2 = new Scripture(
            new Reference("Ether", 12, 27),
            "And if men come unto me I will show unto them their weakness."
        );

        Scripture sr3 = new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart and lean not unto thine own understanding."
        );

        scriptures.Add(sr1);
        scriptures.Add(sr2);
        scriptures.Add(sr3);

        Random random = new Random();
        Scripture chosenScripture = scriptures[random.Next(scriptures.Count)];

        while (!chosenScripture.AllWordsHidden())
        {
            Console.Clear();

            Console.WriteLine(chosenScripture.GetDisplayText());

            Console.WriteLine();
            Console.Write("Press ENTER to continue or type 'quit': ");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            chosenScripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(chosenScripture.GetDisplayText());
        Console.WriteLine("\nProgram ended.");
    }
}