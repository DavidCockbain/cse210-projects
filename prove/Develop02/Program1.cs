using System;
using System.IO;
public class Program1
{
    static void Main(string[] args)
{
        
        Journal1 journal = new Journal1();

        
        Console.WriteLine("Welcome to Your Daily Journal!");
    
        while (true) {
            Console.WriteLine("Please select one of the follwing choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
        
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            
            switch (choice) {
                
                case "1":
                journal.AddEntry();
                break;

                
                case "2":
                journal.DisplayEntries();
                break;

                
                case "3":
                journal.LoadFromFile();
                break;

                
                case "4":
                journal.SaveToFile();
                break;

                
                case "5":
                Console.WriteLine("Goodbye!");
                return;

                
                default:
                Console.WriteLine("Invalid selection, please enter a number 1-5.");
                break;
            }
        }
    }
}
