using System;

class Program
{
    static void Main(string[] args)
    {
        //prompt for names

        Console.Write("What is your name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        //display
        Console.WriteLine($"\nYour name is {lastName}, {firstName} {lastName} .");
    }
}