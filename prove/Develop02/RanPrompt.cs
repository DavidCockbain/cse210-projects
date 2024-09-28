using System;

public class Prompt
{
static void Main(string[] args)
{
    
    var random = new Random();
    var list = new List<string>{ "If I had one thing I could do over today, what would it be?","What was the strongest emotion I felt today?","How did I see the hand of the Lord in my life today?","What was the best part of my day?","Who was the most interesting person I interacted with today?"};
    int index = random.Next(list.Count);
    Console.WriteLine(list[index]);
    
        public static void Display()
        {
        Console.WriteLine(list[index]);
        }
    
        
   
} 
}
