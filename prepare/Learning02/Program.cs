using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2024;
        job1._endYear = 2027;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Designer";
        job2._startYear = 2024;
        job2._endYear = 2025;

        Resume res1 = new Resume();
        res1._name = "Higor Rofino";
        res1._jobs.Add(job1);
        res1._jobs.Add(job2);
        res1.Display();
    }
}