using System;

namespace Develop02
{
    public class Entry
    {
        public string _date { get; set; }
        public string _promptText { get; set; }
        public string _entryText { get; set; }
        public string _moodRating { get; set; } // Creative Addition: Mood tracker attribute

        // Displays the entry in a clean, readable format
        public void Display()
        {
            Console.WriteLine($"Date: {_date} — Prompt: {_promptText}");
            Console.WriteLine($"Mood: {_moodRating}/5");
            Console.WriteLine($"Response: {_entryText}");
            Console.WriteLine(new string('-', 50)); // Visual divider
        }
    }
}