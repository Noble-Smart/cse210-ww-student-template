// Program.cs

using System;

class Program
{
    static void Main(string[] args)
    {
        // Create jobs
        Job job1 = new Job();
        job1.Company = "Microsoft";
        job1.JobTitle = "Software Engineer";
        job1.StartYear = 2019;
        job1.EndYear = 2022;

        Job job2 = new Job();
        job2.Company = "Apple";
        job2.JobTitle = "Manager";
        job2.StartYear = 2022;
        job2.EndYear = 2023;

        // Create a new resume
        Resume myResume = new Resume();
        myResume.Name = "Allison Rose";

        // Add jobs to the resume
        myResume.Jobs.Add(job1);
        myResume.Jobs.Add(job2);

        // Display resume
        myResume.DisplayResume();

        Console.ReadKey(); // Pause the program before closing
    }
}