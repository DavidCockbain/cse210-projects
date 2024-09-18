using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your first name. ");
        string firstname = Console.ReadLine();

        Console.Write("Please enter your last name. ");
        string lastname = Console.ReadLine();

        Console.WriteLine($"Hello {lastname} {firstname} {lastname}.");

    //    Console.Write("What is your first name? ");
    //    string firstname = Console.ReadLine();

    //    Console.Write("What is your last name? ");
    //    string lastname = Console.ReadLine();

    //    Console.WriteLine($"Your name is {lastname} {firstname} {lastname}.");
    }
}