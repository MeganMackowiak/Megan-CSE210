using System;
using System.Collections.Generic;
using System.IO;

namespace Develop02
{
    public class Journal
    {
        public List<Entry> _entries = new List<Entry>();
        
        // List containing at least 5 creative prompts
        private List<string> _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is a lesson you learned today that you want to remember tomorrow?",
            "What did you do today that brought you a sense of peace?"
        };

        // Selects a prompt randomly from the list
        public string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            return _prompts[index];
        }

        // Adds a user-created entry to the internal list
        public void AddEntry(Entry newEntry)
        {
            _entries.Add(newEntry);
        }

        // Displays all entries or alerts if the list is empty
        public void DisplayAll()
        {
            if (_entries.Count == 0)
            {
                Console.WriteLine("\nYour journal is currently empty. Try writing an entry first!");
                return;
            }

            Console.WriteLine("\n=== Journal Entries ===");
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }

        // Saves current entries to a file using a unique delimiter "~|~"
        public void SaveToFile(string file)
        {
            using (StreamWriter outputFile = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    // Saves data separated by ~|~ to bypass potential comma issues
                    outputFile.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}~|~{entry._moodRating}");
                }
            }
            Console.WriteLine($"Journal successfully saved to {file}.");
        }

        // Loads entries from a file and replaces the current memory list
        public void LoadFromFile(string file)
        {
            if (!File.Exists(file))
            {
                Console.WriteLine("Error: That file could not be found.");
                return;
            }

            _entries.Clear(); // Replaces any current entries stored in runtime memory
            string[] lines = File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string[] parts = line.Split("~|~");
                if (parts.Length == 4)
                {
                    Entry loadedEntry = new Entry
                    {
                        _date = parts[0],
                        _promptText = parts[1],
                        _entryText = parts[2],
                        _moodRating = parts[3]
                    };
                    _entries.Add(loadedEntry);
                }
            }
            Console.WriteLine($"Journal successfully loaded from {file}.");
        }
    }
}