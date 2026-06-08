using System;

class Program
{
    static void Main(string[] args)
    {
        Word myWord = new Word("Hello");
        Console.WriteLine(myWord.GetWordString());

        myWord.Hide();
        Console.WriteLine(myWord.GetWordString());


        myWord.DisplayWord();
        if(myWord.IsHidden())
        {
           Console.WriteLine(myWord.GetWordString()); 
        }

    

    //scripture.cs implimentation 


    list<Scripture> scriptures = new List<Scripture>():
    Scripture sr = new Scripture ("John", 3, 17, "For God sent not his Son into the world to condemn the world; but that the world through him might be saved");
    Scripture sr1 = new Scripture("John", 3, 17, "For God sent not his Son into the world to condemn the world; but that the world through him might be saved");
    Scripture sr2 = new Scripture("Ether", 12, 27, "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");
    Scripture sr3 = new Scripture("Proverbs", 3, 5, 6, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

    scriptures.Add(sr);
    scriptures.Add(sr1);
    scriptures.Add(sr2);
    scriptures.Add(sr3);

    int count = 1 ;
    Console.CLear();
    foreach(Scripture scritpure in scriptures)
    {
        Console.Writeline($"{count} -> {scripture.GetScriptureReferance()}");
        count++;
    }
    }
}