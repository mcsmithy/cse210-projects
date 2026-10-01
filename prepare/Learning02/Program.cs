using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Google";
        job1._jobtitle = "Janitor";
        job1._startYear = 2018;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "Amazon";
        job2._jobtitle = "CEO";
        job2._startYear = 2002;
        job2._endYear = 2018;

        Resume myResume = new Resume();
        myResume._name = "Bruce Wayne";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        myResume.Display();
    }
}