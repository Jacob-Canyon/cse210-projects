using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using Develop02;

namespace Develop02;

public class Entry
{
public string _date;
public string _promptText;
public string _entryText;

public void DisplayEntry()
{
  Console.WriteLine($"Date:{_date} -- Prompt: {_promptText}\n{_entryText}");

}
}
