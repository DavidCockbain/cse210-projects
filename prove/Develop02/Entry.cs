using System;
using System.Net.Mime;

public class Entry 
{

public string Content {get;}
public string DateCreated {get;}

public Entry (string dateInput, string content) 
{

Content = content;
}

    
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {DateCreated}");
        Console.WriteLine($"Content: {Content}\n");
    }

}
class Code{


}
public class Journal 
{
public List <Entry> entries;
public PromptGenerator promptGenerator;

    
    public Journal() 
    {
        entries = new List<Entry>();
        
        promptGenerator = new PromptGenerator();
        
    }

    
    public void AddEntry() 
    {
    
        string prompt = promptGenerator.GenerateRandomPrompt();

        

        DateTime theCurrentTime = DateTime.Now;
        string DateCreated = theCurrentTime.ToShortDateString();
        Console.Write($"the date({DateCreated}): ");
        Console.WriteLine($"Today's Prompt: {prompt}");

        Console.Write("> ");

        string content = Console.ReadLine();
    
        

        
    }

    
    public void DisplayEntries() 
    {
        foreach (Entry entry in entries) 
        {
    //         public List<string[]> parseCSV(string path)
    // {
    //    // List<string[]> parsedData = new List<string[]>();
    //     try
    //     {
    //         using (StreamReader readfile = new StreamReader(path))
    //         {
    //             string line;
    //             string[] row;
    //             while ((line = readfile.ReadLine()) != null)
    //             {
    //                 row = line.Split('\t');
    //                 parsedData.Add(row);
    //             }
    //         }
    //     }
    //     catch (Exception e)
    //     {
        
    //     }

    //     return parsedData;
    // }

            entry.DisplayEntry();
            
        }
    }

    
    public void SaveToFile() 
    {
        Console.Write("Please enter the filename you would like to save to: ");
        string filename = Console.ReadLine();
        try {
            using (StreamWriter writer = new StreamWriter(filename)) 
            {
                foreach (Entry entry in entries) 
                {
                    writer.WriteLine($"{entry.DateCreated}\n{entry.Content}");
                }
            }
            Console.WriteLine($"Journal entries saved to {filename}");
        } catch (Exception e) 
        {
            Console.WriteLine($"Error saving entries to {filename}: {e.Message}");
        }
    }

    //Loads Entries from a file named by the user
    public void LoadFromFile() 
    {
        Console.Write("Please enter the file name you would like to load from: ");
        String filename = Console.ReadLine();
        filename = ($"{filename}.txt");
        try {
            using (StreamReader reader = new StreamReader(filename)) 
            {
                while (!reader.EndOfStream) 
                {
                    string dateString = reader.ReadLine();
                    string content = reader.ReadLine();
                    Entry entry = new Entry(dateString, content);
                    entries.Add(entry);
                }
            } 
        } catch (Exception e) 
        {
                Console.WriteLine($"Error loading entries from :filename: {e.Message}");
        }
    }

}