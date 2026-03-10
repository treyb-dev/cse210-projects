using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 1986;
        job1._endYear = 2026;
        job1.Display();
        

        Job job2 = new Job();
        job2._jobTitle = "Data Analyst";
        job2._company = "Google";
        job2._startYear = 1977;
        job2._endYear = 2027;
        job2.Display();

        Resume myResume = new Resume();
        myResume._familyName = "John";
        myResume._givenName = "Burton";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}