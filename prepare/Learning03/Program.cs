using System;

class Program
{
    static void Main(string[] args)
    {
        // Test constructors
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1, 3);

        // Display fractions and decimal values
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        Console.WriteLine();

        // Practice using getters and setters
        Fraction practice = new Fraction();

        Random random = new Random();

        for (int i = 1; i <= 20; i++)
        {
            int top = random.Next(1, 11);
            int bottom = random.Next(1, 11);

            practice.SetTop(top);
            practice.SetBottom(bottom);

            Console.WriteLine(
                $"Fraction {i}: string: {practice.GetFractionString()} Number: {practice.GetDecimalValue()}"
            );
        }
    }
}