using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstName;
        firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        String lastName = Console.ReadLine();

        Console.WriteLine($"{lastName}, {firstName}{lastName}"); 
    
    }
}