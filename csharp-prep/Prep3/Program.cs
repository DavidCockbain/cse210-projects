using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
       int loop = 0;
        
        
        do
        {
            

            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;

        
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    
                }
            }
            Console.WriteLine("Do you want to play again?");
            Console.WriteLine("Type yes to play again and type no to quit:");
            string input = Console.ReadLine();
            if (input == "yes")
            {
             loop = 1; 
            }
            else if (input == "no")
            {
                loop = 0;
            }
            }
        while (loop == 1);
        }           
}