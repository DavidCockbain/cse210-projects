using System;
using System.ComponentModel;


Console.Write("what is your grade percentage? ");
string input = Console.ReadLine();
int gradepercent = int.Parse(input);

string gradeletter = "";

if (gradepercent >= 90)
{
    gradeletter = "A"; 
}
else if (gradepercent >= 80)
{
    gradeletter = "B";
}
else if (gradepercent >= 70)
{
    gradeletter = "C"; 
}
else if (gradepercent >= 60)
{
    gradeletter = "D";

}
else if (gradepercent < 60)
{
    gradeletter = "F";
    
}
Console.WriteLine($"your grade is {gradeletter} ");
if (gradepercent >= 70)
        {
            Console.WriteLine("Congratulations you passed!");
        }
        else
        {
            Console.WriteLine("Good try you will get it next time!");
        }


