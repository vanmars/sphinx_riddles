using System;
using System.Collections.Generic;

public class Program
{
  public static void Main()
  {
    // Begin Game
    Console.WriteLine("*************************************************");
    Console.WriteLine("YOU HAVE ENTERED THE LAIR OF THE SPHINX!");
    Console.WriteLine("*************************************************");
    Console.WriteLine("You have no choice but to answer the riddles of Sphinx if you hope to escape.");
    Console.WriteLine("Answer correctly, and you'll defeat the Sphinx.");
    Console.WriteLine("Answer incorrectly, . . . and you'll be devoured!");
    Console.WriteLine("*************************************************");
    
    
    // Provide First Riddle and Capture Response
    Console.WriteLine("RIDDLE: What has roots as nobody sees, is taller than trees. Up, up it goes, and yet never grows?");
    string answer = Console.ReadLine();
    string answerToLower = answer.ToLower();

    // Conditionals for Responding to Questions
    if (answerToLower.Contains("mountain"))
    {
      Console.WriteLine("Congratulations, wise one! You have defeated the Spinx.");
    }
    else
    {
      Console.WriteLine("Uh oh . . . you have answered incorrectly. You have been devoured by the Sphinx.");
    }
  }
}
