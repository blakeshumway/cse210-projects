using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {

        //create new object
        Job job1 = new Job();

        //define objects attributes
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2020;
        job1._endYear = 2025;

        //create second object and assign attributes
        Job job2 = new Job();
        job2._jobTitle = "Software Specialist";
        job2._company = "Apple";
        job2._startYear = 2019;
        job2._endYear = 2023;

        //Console.WriteLine(job1._company);
        //Console.WriteLine(job2._company);
        //job1.Display();
        //job2.Display();


        //create new object and assign attributes
        Resume myResume = new Resume();
        myResume._name = "John Shelton";

        //add both job objects to a list called _jobs
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);


        //calls a method called display that also calls a method called display in Jobs.cs
        myResume.Display();
    }
}