using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> number = new List<int>();
        int numbers = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        //get numbers from user until they enter 0
        while (numbers != 0)
        {
            Console.Write("Enter number: ");
            numbers = int.Parse(Console.ReadLine());

            //only add non-zero to the list
            if (numbers != 0)
            {
                number.Add(numbers);
            }
        }

        //compute sum
        int sum = number.Sum();
        Console.WriteLine($"The sum is: {sum}");

        //compute the average
        double average = number.Average();
        Console.WriteLine($"The average is: {average}");

        int max = number.Max();
        Console.WriteLine($"The largest number is: {max}");
        
    }
}