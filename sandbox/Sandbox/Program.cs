//using System;
// using System.Collections.Generic;
// using System.ComponentModel.DataAnnotations;
// using System.IO;
// using System.Runtime.InteropServices.Marshalling;
// class Program
// {
//     static void Main(string[] args)
//     {
//         Save s1 = new Save();
//         s1._userin = "one"; 
//         string userin1 = Console.ReadLine();
        
//         Console.WriteLine(userin1);
//         Save s2 = new Save();
//         s2._userin = "two";
//         //string userin2 = Console.ReadLine();
//         //Console.WriteLine(userin2);
//        List<Save> num = new List<Save>(); 
//        num.Add(s1);
//        num.Add(s2);
       
       

//        foreach (Save s in num)
//        {
//         Console.WriteLine(s._userin);
//        }
//        SaveToFile(num);
//     }
//         public static void SaveToFile(List<Save> num)
//         {
//             Console.WriteLine("Saving to file.....");
//             string filename = "text.txt";

//             using(StreamWriter outputFile = new StreamWriter(filename))
//             {
//                 foreach (Save s in num)
//                 {
//                     string input = "hello world";
//                     outputFile.WriteLine($"Numbers {input} ");
//                     Console.WriteLine("Saved");
//                 }
//             }
//         }

// }

Console.Write("Please enter the file name you would like to load from: ");
        String filename = Console.ReadLine();
        filename = ($"{filename}.txt");
        Console.Write(filename);