using System.ComponentModel.Design;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Develop05;

public class GoalManager
{
    List<Goal> _listOfGoals;

    private int _score;

    public GoalManager()
    {
        _listOfGoals = new List<Goal>();

        _score = 0;
    }

    public void CreateNewGoal()
    {
        
    }

    public void SaveGoals(List<Goal> goals)
    {
        string fileName = "SavedGoals.txt";

        using (StreamWriter outputfile = new StreamWriter(fileName))
        {  
            Console.WriteLine("Saving Goals......");
            outputfile.WriteLine(_score);


            foreach (Goal goal in goals)
            {
                outputfile.WriteLine(goal.GetStringRepresentation());
            }
        }

    }

    public void LoadSavedGoals()
    {
        Console.WriteLine("Loading file......");
        
        string fileName = "SavedGoals.txt";

        string[] lines = System.IO.File.ReadAllLines(fileName);
        _score = int.Parse(lines[0]);
        foreach(string line in lines)
        {
            string[] parts = line.Split("|");
            if(parts[0] == "SimpleGoal")
                {
                    SimpleGoal newSimpleGoal = new SimpleGoal(parts[1],parts[2],parts[3],parts[4]);
                    _listOfGoals.Add(newSimpleGoal);
                }

            if(parts[0] == "EternalGoal")
                {
                    EternalGoal newEternalGoal = new EternalGoal(parts[1],parts[2],parts[3]);
                    _listOfGoals.Add(newEternalGoal);

                }

            if(parts[0] == "ChecklistGoal")
            {
                ChecklistGoal newChecklistGoal = new ChecklistGoal(parts[1],parts[2],parts[3],parts[4],int.Parse(parts[5]),int.Parse(parts[6]),int.Parse(parts[7]));
                _listOfGoals.Add(newChecklistGoal);
            }

            
        }
    }

    public void ListGoalNames()
    {
        
        int count = 1;
         foreach( Goal goal in _listOfGoals)
                {
                    Console.Write($"{count}. ");
                    Console.WriteLine(goal.GetDetailsString());
                    count++;
                }
        
      
    }

    public void DisplayPlayInfo()
    {
        Console.WriteLine($"You have {_score} points.");
        double level = _score/10000;
        level = Math.Round(level,1);
        Console.WriteLine($"Level: {level}");
    }

    public void Start()
    {
        bool mainLoopStop = false;

        while (mainLoopStop == false)
        {
            DisplayPlayInfo();
            Console.WriteLine();

            Console.WriteLine("Menu:");
            Console.WriteLine(" 1. Ceate New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            string selection = Console.ReadLine();

            if (selection == "1")
            {
                
                bool stop = false;
                while ( stop == false)
                {
                    
                    Console.WriteLine("Types of Goals:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write("Select goal type: ");
                    string goalSelection = Console.ReadLine();

                    if (goalSelection == "1")
                    {
                        Console.Write("What is the name of your goal? ");
                        string goalName = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        string description = Console.ReadLine();
                        Console.Write("What is the point value for this goal?: ");
                        string points = Console.ReadLine();

                        SimpleGoal simpleGoal = new SimpleGoal(goalName, description, points);

                        _listOfGoals.Add(simpleGoal);
                       
                        stop = true;

    

                    }

                    if (goalSelection == "2")
                    {
                        Console.Write("What is the name of your goal? ");
                        string goalName = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        string description = Console.ReadLine();
                        Console.Write("What is the point value for this goal?: ");
                        string points = Console.ReadLine();

                        EternalGoal eternalGoal = new EternalGoal(goalName, description, points);

                        _listOfGoals.Add(eternalGoal);

                        stop = true;


                    }

                    if (goalSelection == "3")
                    {
                        Console.Write("What is the name of your goal? ");
                        string goalName = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        string description = Console.ReadLine();
                        Console.Write("What is the point value for this goal?: ");
                        string points = Console.ReadLine();
                        Console.Write("How many times does this goal need to be completed? ");
                        int target = int.Parse(Console.ReadLine());
                        Console.Write("What is the Bouns for completing this goal? ");
                        int bonus = int.Parse(Console.ReadLine());

                        ChecklistGoal checklistGoal = new ChecklistGoal(goalName,description,points,0,target, bonus);

                        _listOfGoals.Add(checklistGoal);

                        stop = true;
                    }
                }


            }

            if (selection == "2")
            {
                foreach( Goal goal in _listOfGoals)
                {
                    Console.WriteLine(goal.GetDetailsString());
                }
            }

            if(selection == "3")
            {
                SaveGoals(_listOfGoals);
            }

            if(selection == "4")
            {
                LoadSavedGoals();
            }

            if(selection == "5")
            {
                
                ListGoalNames();
                
                Console.Write("Which goal did you accomplish? ");
                int recordSelection = int.Parse(Console.ReadLine());
                recordSelection = recordSelection - 1;
                Goal goal = _listOfGoals[recordSelection];
                int addPoints = goal.GetPoints();
                goal.RecordEvent();

                _score = _score + addPoints;
            }

            if(selection == "6")
            {
                System.Environment.Exit(0);
            }

        

        }
    }
}
