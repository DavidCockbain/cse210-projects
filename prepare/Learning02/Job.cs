using System;

public class Job
{
   public string _company;
   public string _jobTitle;
   public string _startYear;
   public string _endYear;
   public void Display()

   {
    
    Console.WriteLine($"{_jobTitle} at ({_company}) from {_startYear} to {_endYear}.");
   }
}
