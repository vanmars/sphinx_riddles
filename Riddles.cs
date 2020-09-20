using System;
using System.Collections.Generic;

namespace Sphinx.Models
{
  public class RiddleGame
{
  // Public Properties
  public Dictionary<string, string> Riddle1 { get; set; }
  public Dictionary<string, string> Riddle2 { get; set; }
  public Dictionary<string, string> Riddle3 { get; set; }
  public Dictionary<string, string> Riddle4 { get; set; }
  public Dictionary<string, string> Riddle5 { get; set; }
  public Dictionary<string, string> Riddle6 { get; set; }
  public Dictionary<string, string> Riddle7 { get; set; }
  public Dictionary<string, string> Riddle8 { get; set; }
  
  // Constructor
  public RiddleGame ()
  {
    Riddle1 =  new Dictionary<string, string> { {"id", "1"}, {"riddle", "What has roots as nobody sees, is taller than trees. Up, up it goes, and yet never grows?"}, {"riddleAnswer", "mountain"} };
    Riddle2 = new Dictionary<string, string> { {"id", "2"}, {"riddle", "Thirty white horses on a red hill. First they champ. Then they stamp. Then they stand still."}, {"riddleAnswer", "teeth"} };
    Riddle3 = new Dictionary<string, string> { {"id", "3"}, {"riddle", "Voiceless it cries. Wingless flutters. Toothless bites. Mouthless mutters."}, {"riddleAnswer", "wind"} };
    Riddle4 = new Dictionary<string, string> { {"id", "4"}, {"riddle", "An eye in a blue face saw an eye in a green face. 'That eye is like to this eye,' said the first eye, 'But in low place, not in high place."}, {"riddleAnswer", "sun"} };
    Riddle5 = new Dictionary<string, string> { {"id", "5"}, {"riddle", "It cannot be seen, cannot be felt, cannot be heard, cannot be smelt. It lies behind stars and under hills, and empty holes it fills. It comes first and follows after. Ends life, kills laughter."}, {"riddleAnswer", "dark"} };
    Riddle6 =  new Dictionary<string, string> { {"id", "6"}, {"riddle", "A box without hinges, key, or lid. Yet golden treasure inside is hid."}, {"riddleAnswer", "egg"} };
    Riddle7 =  new Dictionary<string, string> { {"id", "7"}, {"riddle", "Alive without breath, as cold as death. Never thirsty, ever drinking. All in mail never clinking."}, {"riddleAnswer", "fish"} };
    Riddle8 =  new Dictionary<string, string> { {"id", "8"}, {"riddle", "This thing all things devours: Birds, beasts, trees, flowers; Gnaws iron, bites steel; Grinds hard stones to meal; Slays king, ruins town, and beats high mountain down."}, {"riddleAnswer", "time"} };
  }

}
}
