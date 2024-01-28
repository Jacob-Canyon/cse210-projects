using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Globalization;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace Develop03;

public class Scripture
{

   private Reference _reference;
   private List<Word> _words = new List<Word>();
   private int _listCount = 0;
   private List<int> _shuffledList = new List<int>();

//Construtors----------------------------------------------------------

   public Scripture(Reference reference, string text)
   {
      _reference = reference;

      string[] spiltText = text.Split(" ");

      foreach (var singleWord in spiltText)
      {
         Word word = new Word(singleWord);
         _words.Add(word);

      }

      List<int> listToShuffle = new List<int>();
      listToShuffle.AddRange(Enumerable.Range(0,_words.Count()));
      Random numberRandom = new Random();
      var shuffledList = listToShuffle.OrderBy(_ =>numberRandom.Next()).ToList();
      foreach(int number in shuffledList)
      {
         _shuffledList.Add(number);
      }
   }

//Methods----------------------------------------------------------


   public void GetDiplayText()
   {

      Console.Write(_reference.GetDiplayText());

      foreach(var word in _words)
      {
         Console.Write(word.GetDiplayText());
         Console.Write(" ");
      }
   }



   public void HideRandomWords(int number)
   {
      for (int i = 0; i < number; i++)
      {
         if(_listCount < _words.Count())
         {
            int index = _shuffledList[_listCount];
            _words[index].Hide();
            _listCount++;
         }
         else
         {
            Console.WriteLine("Goodbye");
            System.Environment.Exit(0);
         }
   
      }
   }

}


