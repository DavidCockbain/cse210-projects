using System;

class Program
{
    static void Main(string[] args)
    {
     List<int> numbers = new List<int>();
             
             
             int userNumber = -1;
             do
             {
                 Console.Write("Enter number. Type 0 to quit: ");
                 
                 string userResponse = Console.ReadLine();
                 userNumber = int.Parse(userResponse);
                 
                 
                 if (userNumber != 0)
                 {
                     numbers.Add(userNumber);
                 }
             }
            while (userNumber != 0);
             
             int sum = 0;
             foreach (int number in numbers)
             {
                 sum += number;
             }
     
             Console.WriteLine($"The sum is: {sum}");
     
             
             float ave = ((float)sum) / numbers.Count;
             Console.WriteLine($"The average is: {ave}");
     
            
             
             int largest = numbers[0];
     
             foreach (int number in numbers)
             {
                 if (number > largest)
                 {
                    
                     largest = number;
                 }
             }
     
             Console.WriteLine($"The largest number is: {largest}");   
    }
}