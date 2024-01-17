using System;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;



class Program
{
    static void Main(string[] args)
    {
       Job job1 = new Job();
       job1._startYear = 2023;
       job1._endYear = 2024;
       job1._jobTitle = "Tech Support";
       job1._company = "Shamley School";


       Job job2 = new Job();
       job2._startYear = 2022;
       job2._endYear = 2023;
       job2._jobTitle = "Technology Teacher";
       job2._company = "Avondale Middle School";


       Resume resume1 = new Resume();

       resume1._jobs.Add(job1);
       resume1._jobs.Add(job2);
       resume1._name = "Jacob Canyon";


       resume1.DisplayResume();


    }
}