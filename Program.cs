using System;
using System.Collections.Generic;
using Sphinx.Models;

namespace Spinx
{
  public class Program
  {
    public static void Main()
    {
      // Create Instance of New Game and New Game List
      RiddleGame Game = new RiddleGame();

      List<Dictionary<string, string>> gameList = new List<Dictionary<string, string>> {Game.Riddle1, Game.Riddle2, Game.Riddle3, Game.Riddle4, Game.Riddle5, Game.Riddle6, Game.Riddle7, Game.Riddle8};

      // Begin Game 
      Console.WriteLine("*************************************************");
      Console.WriteLine("YOU HAVE ENTERED THE LAIR OF THE SPHINX!");
      Console.WriteLine("*************************************************");
      Console.WriteLine("You have no choice but to answer the riddles of Sphinx if you hope to escape.");
      Console.WriteLine("Answer correctly, and you'll defeat the Sphinx.");
      Console.WriteLine("Answer incorrectly, . . . and you'll be devoured!");
      Console.WriteLine("*************************************************");
      
      // Game Play Loop
      foreach (Dictionary<string, string> riddle in gameList)
      {
        Console.WriteLine("Riddle: " + riddle["riddle"]);
        string answer = Console.ReadLine();
        string answerToLower = answer.ToLower();
        if (riddle["id"] == "8")
        {
          if (answerToLower.Contains(riddle["riddleAnswer"]))
          {
            Console.WriteLine("*** Congratulations, wise one! You have defeated the mighty Sphinx. ***");
          }
          else
          {
            Console.WriteLine("Uh oh . . . you have answered incorrectly. You have been devoured by the Sphinx.");     
         }
        }
        else
        {
          if (answerToLower.Contains(riddle["riddleAnswer"]))
          {
            Console.WriteLine("*** Well done, you are correct. You will continue to the next round with the Spinx. ***");
          }
          else
          {
            Console.WriteLine("Uh oh . . . you have answered incorrectly. You have been devoured by the Sphinx.");     
            break; 
         }
        }
      }
      
    }
  }
}
