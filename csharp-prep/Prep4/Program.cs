using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> number = new List<int>();

        int inputNum = -1;
        while (inputNum != 0)
        {
            Console.Write("Please enter any number(to stop put 0 ");

            string userInput = Console.ReadLine():
            inputNum = int.Parse(userInput);

            if(inputNum != 0)
            {
                number.Add(inputNum);
            }
        }
        int sum = 0; 

        foreach (int numbers in number)
        {
            sum += numbers;
        }
        
        Console.WriteLine($"The total is: {sum}");

        float average = ((float)sum) / number.Count; 

        Console.WriteLine($"The average is: {average}");




        int max = number[0];

        foreach  (int numbers in number);
        {
            if(number > max)
            {
                max = number; 
            }
        } 

        Console.WriteLine($"The max is: {max}");
    }
}