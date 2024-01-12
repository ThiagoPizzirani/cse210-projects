using System;

class Program
{
    static void Main(string[] args)
    {
        Jobs job1 = new Jobs();
        job1._jobTitle = "Database Specialist";
        job1._company = "IBM";
        job1._startYear = 2002;
        job1._endYear = 2010;

        Jobs job2 = new Jobs();
        job2._jobTitle = "Quality Control";
        job2._company = "Toyota";
        job2._startYear = 1998;
        job2._endYear = 2013;

     //   job1.Display();
     //   job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Thiago Pizzirani";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}