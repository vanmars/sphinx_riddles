using System;
using System.Collections.Generic;
using Sphinx.Models;

namespace Spinx
{
  public class Program
  {
    public static void Main()
    {
      // Create Instance of New Game
      RiddleGame Game = new RiddleGame();

      // Begin Game
      Console.WriteLine("*************************************************");
      Console.WriteLine("YOU HAVE ENTERED THE LAIR OF THE SPHINX!");
      Console.WriteLine("*************************************************");
      Console.WriteLine("You have no choice but to answer the riddles of Sphinx if you hope to escape.");
      Console.WriteLine("Answer correctly, and you'll defeat the Sphinx.");
      Console.WriteLine("Answer incorrectly, . . . and you'll be devoured!");
      Console.WriteLine("*************************************************");
      
      
      // Provide First Riddle and Capture Response
      Console.WriteLine("Riddle: " + Game.Riddle1["riddle"]);
      string answer = Console.ReadLine();
      string answerToLower = answer.ToLower();
      // Conditionals for Responding to Second Question
      if (answerToLower.Contains(Game.Riddle1["riddleAnswer"]))
      {
        Console.WriteLine("*** Well done, you are correct. You will continue to the next round with the Spinx. ***");
        // Provide Second Riddle and Capture Response
        Console.WriteLine("Riddle: " + Game.Riddle2["riddle"]);
        string answer2 = Console.ReadLine();
        string answerToLower2 = answer2.ToLower();
        // Conditionals for Responding to Second Question
        if (answerToLower2.Contains(Game.Riddle2["riddleAnswer"]))
        {
          Console.WriteLine("Congratulations, wise one! You have defeated the Spinx.");
        }
        else
        {
          Console.WriteLine("Uh oh . . . you have answered incorrectly. You have been devoured by the Sphinx.");
        }      
      }
      else
      {
        Console.WriteLine("Uh oh . . . you have answered incorrectly. You have been devoured by the Sphinx.");
      }

     

    }
  }
}
