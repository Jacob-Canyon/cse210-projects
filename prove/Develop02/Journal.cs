using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using Develop02;
using System.IO;
using System.Security;

namespace Develop02;

public class Journal
{
public List<Entry> _entries =new List<Entry>();




public void AddEntry(Entry entry)
{
    _entries.Add(entry);
}

public void   LoadFile(List<Entry> entries)  
{
    string fileName = "myJournal.txt";
    string[] lines = System.IO.File.ReadAllLines(fileName);
    foreach (string line in lines)
    {
        Entry entry = new Entry();

        string[] parts = line.Split("|");

        entry._date = parts[0];
        entry._promptText = parts[1];
        entry._entryText = parts[2];

        entries.Add(entry);

        Console.WriteLine("File loaded\n");
    
    }


}


public void SaveToFile(List<Entry> entries)
{
    
    string fileName = "myJournal.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))

            foreach (Entry e in entries)
            {
                outputFile.WriteLine($"{e._date}|{e._promptText}|{e._entryText}");
            }
    Console.WriteLine("Saving...........\n");
    

}

public void ClearFile()
{
    string fileName = "myJournal.txt";

    File.WriteAllText(fileName, string.Empty);
}
 public void DisplayAll()
{
    foreach (Entry entries in _entries)
    {
        entries.DisplayEntry();
    }
}

}
