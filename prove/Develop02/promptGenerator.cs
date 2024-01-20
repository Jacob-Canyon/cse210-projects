using System.Dynamic;
using Microsoft.VisualBasic;

namespace Develop02;

public class promptGenerator
{

List<string> list = new List<string>(){"What do you wish you could do different?", "Who do you think you had the greatest impacted today?", "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?", "What is the most important lesson you learned today?", "What is one thing you do not want to forget from today?","What is something you wish future generations knew about your day?","Tell of how the Lord has blessed you today.","What is one way that are better than you were yesterday?"
    ,"What is the best thing that happen to you today?","What is the most important lesson that you learned today?"};

public string GeneratePrompt()
{
   
    
    var random = new Random();

    int index = random.Next(list.Count);

    return list[index];
}
}
