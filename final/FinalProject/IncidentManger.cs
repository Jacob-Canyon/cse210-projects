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
                string[] parts = line.Split("|");
                if(parts[1] == studentID)
                {
                    Console.WriteLine($"Name: {parts[2]} Grade: {parts[3]} Level: {parts[6]} Description: {parts[7]} ");
                }
                
            }
    }

    public void GenerateReport()
    {
        int grade1 = 0;
        int grade2 = 0;
        int grade3 = 0;
        int grade4 = 0;
        int grade5 = 0;
        int grade6 = 0;
        int grade7 = 0;
        int grade8 = 0;

        int middle = 0;
        int elementary = 0;

        int incidents = _incidents.Count();

        foreach (string line in _saves)
        {

            string[] parts = line.Split("|");
            if (parts[6] == "1")
            {
                grade1++;
            }

            if (parts[6] == "2")
            {
                grade2++;
            }
            if (parts[6] == "3")
            {
                grade3++;
            }
            if (parts[6] == "4")
            {
                grade4++;
            }
            if (parts[6] == "5")
            {
                grade5++;
            }
            if (parts[6] == "6")
            {
                grade6++;
            }

            if (parts[6] == "7")
            {
                grade7++;
            }

            if (parts[6] == "8")
            {
                grade8++;
            }

            if(parts[0] == "ElementarySchool")
            {
                elementary++;
            }

            if(parts[0] == "MiddleSchool")
            {
                middle++;
            }
        }

        Console.WriteLine($"Total Reported Incidents: {incidents}");
        Console.WriteLine($"Middle School: {middle}");
        Console.WriteLine($"Elementary School: {elementary}");
        Console.WriteLine($"1st Grade: {grade1} 2nd Grade: {grade2} 3rd Grade: {grade3} 4th grade: {grade4} 5th Grade: {grade5} 6th Grade: {grade6} 7th Grade: {grade7} 8th Grade: {grade8}");
    }



    public void Start()
    {
        bool stop = false;
        while (stop == false)
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine();
            Console.WriteLine("1. Report Incident");
            Console.WriteLine("2. Search Student");
            Console.WriteLine("3. Display Behavior Report");
            Console.WriteLine("4. SAVE");
            Console.WriteLine("5. LOAD");
            Console.WriteLine("6. QUIT");
            Console.WriteLine();
            Console.Write("Enter Selection: ");
            string Selection = Console.ReadLine();

            if (Selection == "1")
            {
                string front = CreateStudent();
                string back = CreateIncident();
                MakeSaveFormat(front,back);
                

                
            }

            if (Selection == "2")
            {
               
                SearchStudent();
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
