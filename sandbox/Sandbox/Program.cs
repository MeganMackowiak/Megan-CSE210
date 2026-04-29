using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        int x = 10; 

        if (x == 11) // don't put a ; behind this line and you will get the result you are looking for 
        {
            Console.WriteLine("Hey Bob"); 
        }

        //this is a for loop 
        for(int i = 0; i < 10; i++) //counting loop goes from 0 to 9 
        {
            Console.WriteLine(i);
        } 

        //While loop 
        int age = -1;

        while (age < 0 || age > 125)
        {
            Console.Write("Please enter your age: ");
            age = int.Parse(Console.ReadLine());
        }
        //DoWhile Lopp 
        int age2; 

        do
        {
            Console.Write("Please enter your age: ");
            age2 = int.Parse(Console.ReadLine());
        }   while (age2 < 0 || age2 >125);

    } 


} 