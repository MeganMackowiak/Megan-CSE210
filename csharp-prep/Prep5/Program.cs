using System;
using System.Text.Json.Serialization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

       string userName = PromptUserName();

       int userNumber = PromptUserNumber();

       int squaredNumber = SquaredNumber(userNumber);

       int birthYear; 

       PromptUserBirthYear(out birthYear);

       DisplayResult(userName, squaredNumber, birthYear);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!! ");
    }

    static string PromptUserName()
    {
        Console.Write("Please input your name: ");
        int number = int.Parse(Console.ReadLine());
        return number; 
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.write($"Enter the year you were born: ");
        birthYear = int.Parse(Console.Readline());
    }

    static int SquaredNumber(int number)
    {
        int square = number * number; 
        return square; 
    }

    static void Displayresults(string name, int square, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.);
        Console.WriteLine($"{name}, you will turn {2026- birthyear} years old this year.");
    }
}