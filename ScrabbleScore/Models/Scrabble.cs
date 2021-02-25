// In this class file, make sure the namespace matches the name of your project (the equivalent of ProjectName). For instance:

namespace ScrabbleScore.Models
{
  public class ScrabbleWord
  {
//     properties, constructors, methods, etc. go here
// 
    public string Letters { get; set; }
    // public int counter {get; set;}
    
    public ScrabbleWord(string letters)
    {
      Letters = letters;
      
    }
  }
}