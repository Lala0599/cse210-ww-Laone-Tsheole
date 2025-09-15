using System;

class Program
{
    static void Main(string[] args)
    {
        //Requirement 1: Ask for grade percentage and determine letter grades
        Console.WriteLine("Enter your grade percentage: ");
        int gradePercentage = int.Parse(Console.Readline());

        string letter = "";

        //Requirement 3: Use a variable to store the letter grade
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        //Requirement 3: Single print statement for letter grade
        Console.WriteLine($"Your letter grade is: {letter}");

        //Requirement 2: Determine if passed and display appropriate message
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Don't give up. You'll do better next time!");
        }

        //stretch challenge: Add + or - signs
        string sign = "";
        int lastDigit = gradePercentage % 10;

        //determine sign based on last digit
        if (gradePercentage >= 60 && gradePercentage < 94) //exclude A+ and F grades
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        //handling exceptional cases
        if (letter == "A" && gradePercentage >= 93)
        {
            sign = ""; //no A+ grade, only A and A-
        }
        else if (letter == "A" && gradePercentage < 93 && lastDigit < 3)
        {
            sign = "-";
        }

        if (letter == "F")
        {
            sign = ""; //no F+ or F- grades
        }

        //display final grade with sign
        Console.WriteLine($"Your final grade is: {letter}{sign}");
    }
}