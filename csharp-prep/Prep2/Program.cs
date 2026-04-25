using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello, what is your grade percentage? ");
        string valueInputed = Console.ReadLine();

        int x = int.Parse(valueInputed);

        string letter ="";


        if ( x>=90 )
        {
           letter = "A";
        }

        else if (x >= 80)
        {
            letter = "B";
        }

        else if (x >= 70)
        {
            letter = "C";
        }

        else if (x >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }


        Console.WriteLine($"Your grade is: {letter}");

        if (x >= 70)
        {
            Console.WriteLine("Congradulations you passed!!");
        }

        else
        {
            Console.WriteLine("I am sorry you did not pass.");
        }

    }
}