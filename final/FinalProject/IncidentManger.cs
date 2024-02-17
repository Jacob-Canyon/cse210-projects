namespace FinalProject;

public class IncidentManger
{
    List<Incident> _incidents = new List<Incident>();
    List<Student> _students = new List<Student>();

    public void Save()
    {
        string fileName = "Behavior.txt";

        using (StreamWriter outputfile = new StreamWriter(fileName))
        {  
            Console.WriteLine("Saving......");
            outputfile.WriteLine();
        }
    }

    public void Load()
    {
        Console.WriteLine("Loading file......");
        
        string fileName = "Behavior.txt";

        string[] lines = System.IO.File.ReadAllLines(fileName);
    }

    public void CreateStudent()
    {

    }

    public void SearchStudent()
    {

    }

    public void GenerateReport()
    {

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
                Incident incident = new Incident("test date","test time","test level");
                incident.DisplayDetails();
            }

            if (Selection == "2")
            {
                Console.Write("Enter Student ID: ");
                string studentID = Console.ReadLine();
            

                foreach (Student student in _students)
                {
                    string name = student.GetName();
                    if (studentID == name)
                    {
                        Console.WriteLine("testing");
                    }

                }
            
            }

            if (Selection == "3")
            {
              
            }
            
            if (Selection == "4")
            {
                Save();
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
