using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;

namespace FinalProject;

public class IncidentManger
{
    List<Incident> _incidents = new List<Incident>();
    List<string> _saves = new List<string>();

    public void Save(List<string> saves)
    {
        string fileName = "Behavior.txt";

        using (StreamWriter outputfile = new StreamWriter(fileName))
        {  
            Console.WriteLine("Saving......");

            foreach (string save in saves)
            {
                outputfile.WriteLine(save);
            }
        }
    }

    public void Load()
    {
        Console.WriteLine("Loading file......");
        
        string fileName = "Behavior.txt";

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            _saves.Add(line);
            string[] parts = line.Split("|");
            if (parts[6] == "1")
            {
                Level1 level1 = new Level1(parts[5],parts[6],parts[7],parts[8],parts[9],parts[10],parts[11]);
                _incidents.Add(level1);
            }

            if (parts[6] == "2")
            {
                Level2 level2 = new Level2(parts[5],parts[6],parts[7],parts[8],parts[9],parts[10],parts[11]);
                _incidents.Add(level2);
            }
            
            if (parts[6] == "3")
            {
                Level3 level3 = new Level3(parts[5],parts[6],parts[7],parts[8],parts[9],parts[10],parts[11]);
                _incidents.Add(level3);
            }
        }
    }

    public void MakeSaveFormat(string front, string back)
    {
        string preFix = front;
        string postFix = back;
        string save = preFix + postFix;
        _saves.Add(save);
        Console.WriteLine(save);

    }

    public string GetDate()
    {
        DateTime dateTime = DateTime.Today;
        string date = (dateTime.ToString("dd/MM/yyyy"));
        return date;
    }

    public string CreateStudent()
    {
        Console.Write("1. Elemnetry or 2. Middle school student: ");
        string selection = Console.ReadLine();

        Console.Write("Enter student name; ");
        String studentName = Console.ReadLine();

        Console.Write("Enter student ID number: ");
        string idNumber = Console.ReadLine();

        Console.Write("Enter Grade:");
        string grade = Console.ReadLine();



        if(selection == "1")
        {
            Console.Write("Enter Teacher: ");
            string teacher = Console.ReadLine();

            ElementarySchool elementarySchool = new ElementarySchool(studentName, grade, idNumber,teacher);
            return elementarySchool.SaveFormat();

        }

        if(selection == "2")
        {
            Console.Write("Enter Homeroom Teacher: ");
            string teacher = Console.ReadLine();

            MiddleSchool middleSchool = new MiddleSchool(studentName, grade, idNumber, teacher);
            return middleSchool.SaveFormat();

        }

        else
        {
            return "error";
        }

   


    }

    public string CreateIncident()
    {
        Console.Write("Enter Level of Incident: ");
        string selection = Console.ReadLine();

        Console.Write("Time of the incident: ");
        string time = Console.ReadLine();

        Console.Write("description of the event: ");
        string description = Console.ReadLine();

        Console.Write("Location of the incident: ");
        string location = Console.ReadLine();

        

        if(selection == "1")
        {
            Console.Write("What action was take:");
            string actionTaken = Console.ReadLine();

            Console.Write("Name of Guradian Contacted: ");
            string guradian = Console.ReadLine();

            string date = GetDate();

            Level1 level1 = new Level1(time, selection, description, location, actionTaken, guradian, date);
            _incidents.Add(level1);
            string save = level1.SaveFormat();
            return save;

        }

        if(selection == "2")
        {
            Console.Write("What action was take:");
            string actionTaken = Console.ReadLine();

            Console.Write("Name of Guradian Contacted: ");
            string guradian = Console.ReadLine();

            string date = GetDate();

            Level2 level2 = new Level2(time, selection, description, location, actionTaken, guradian, date);
            _incidents.Add(level2);
            string save = level2.SaveFormat();
            return save;

            

        }
        if(selection == "3")
        {
            Console.Write("Who is the Admin assigned: ");
            string adim =Console.ReadLine();

            Console.Write("How long is the Suspention in days: ");
            string suspention = Console.ReadLine();

            string date = GetDate();

            Level3 level3 = new Level3(time, selection, description, location, adim, suspention, date);
            _incidents.Add(level3);
            string save = level3.SaveFormat();
            return save;
        }
        else
        {
            return "";
        }
    }

    public void SearchStudent()
    {
        Console.Write("Enter Student ID: ");
            string studentID = Console.ReadLine();
            

            foreach (string line in _saves)
            {
             
            }
    }

    public void GenerateReport()
    {
        foreach (Incident incident in _incidents)
        {
            incident.DisplayDetails();
        }
    }



    public void Start()
    {
        bool stop = false;
        while (stop == false)
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("1. Report Incident");
            Console.WriteLine("2. Diplay Student");
            Console.WriteLine("3. Display Behavior Report");
            Console.WriteLine("4. SAVE");
            Console.WriteLine("5. LOAD");
            Console.WriteLine("6. QUIT");
            Console.WriteLine("Enter Selection: ");
            string Selection = Console.ReadLine();

            if (Selection == "1")
            {
                string front = CreateStudent();
                string back = CreateIncident();
                MakeSaveFormat(front,back);
                

                
            }

            if (Selection == "2")
            {
               
            
            }

            if (Selection == "3")
            {
              GenerateReport();
            }
            
            if (Selection == "4")
            {
                Save(_saves);
            }

            if (Selection =="5")
            {
                Load();
            }

            if (Selection =="6")
            {
                System.Environment.Exit(0);
            }
        }

    }
}
