using System;
using System.Collections.Generic;
using Sphinx.Models;

namespace Spinx
{
  public class Program
  {
    public static void Main()
    {
      // Create Instance of New Game, New Game List, and Random Number Generator
      RiddleGame Game = new RiddleGame();
      List<Dictionary<string, string>> gameList = new List<Dictionary<string, string>> {Game.Riddle1, Game.Riddle2, Game.Riddle3, Game.Riddle4, Game.Riddle5, Game.Riddle6, Game.Riddle7, Game.Riddle8};
      System.Random random = new System.Random(); 

      // Begining Game UI 
      Console.WriteLine("*************************************************");
      Console.WriteLine("YOU HAVE ENTERED THE LAIR OF THE SPHINX!");
      Console.WriteLine("*************************************************");
      Console.WriteLine("You have no choice but to answer the riddles of Sphinx if you hope to escape.");
      Console.WriteLine("Answer correctly, and you'll defeat the Sphinx.");
      Console.WriteLine("Answer incorrectly, . . . and you'll be devoured!");
      Console.WriteLine("*************************************************");
      
    // Game Play Loop
      while (gameList.Count > 0)
      {
        // Get Randomized Index
        int max = gameList.Count;
        int index = random.Next(max);
        // Run the Write Line for the riddle at that randomized index
        Console.WriteLine("Riddle: " + gameList[index]["riddle"]);
        string answer = Console.ReadLine();
        string answerToLower = answer.ToLower();
        // Check if on last riddle
        if (gameList.Count == 1)
        {
          if (answerToLower.Contains(gameList[index]["riddleAnswer"]))
          {
            Console.WriteLine("*** Congratulations, wise one! You have defeated the mighty Sphinx. ***");
            gameList.RemoveAt(index);
          }
          else
          {
            Console.WriteLine("Uh oh . . . you have answered incorrectly. You have been devoured by the Sphinx.");  
            gameList.RemoveAt(index);   
         }
        }
        else
        {
          if (answerToLower.Contains(gameList[index]["riddleAnswer"]))
          {
            Console.WriteLine("*** Well done, you are correct. You will continue to the next round with the Spinx. ***");
            gameList.RemoveAt(index);
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
