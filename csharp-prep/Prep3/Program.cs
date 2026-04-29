using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string magicNum = Console.ReadLine();
        int magicNumber = int.Parse(magicNum);

        bool correctAnswer = false;
        do
        {
        

            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            int guessX = int.Parse(guess);



            if (magicNumber > guessX)
            {
                Console.WriteLine("Higher");
            }

            else if (magicNumber < guessX)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Correct");
                correctAnswer = true;
            }
        } while (!correctAnswer);

    }
}