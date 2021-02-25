// In this class file, make sure the namespace matches the name of your project (the equivalent of ProjectName). For instance:
using System.Collections.Generic;
namespace ScrabbleScore.Models
{
  public class ScrabbleWord
  {
//     properties, constructors, methods, etc. go here
// 
    public string Letters { get; set; }
    public char[] LettersArray { get; set; }
    public int Counter {get; set;}
    
    public ScrabbleWord(string letters)
    {
      Letters = letters.ToUpper();
      LettersArray = Letters.ToCharArray();
      Counter = 0;
    }

    public int OneScoreLetters()
    {
      char[] OnePointArray = {'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T'};
      foreach(char pointLetter in OnePointArray)
      {
        foreach (char userLetter in LettersArray)
        {
          if (pointLetter == userLetter)
          {
            Counter += 1;
          }
        }
      }
      return Counter;
    }
    public int TwoScoreLetters()
    {
      char[] TwoPointArray = {'D', 'G'};
      foreach(char pointLetter in TwoPointArray)
      {
        foreach (char userLetter in LettersArray)
        {
          if (pointLetter == userLetter)
          {
            Counter += 2;
          }
        }
      }
      return Counter;
    }
    public int ThreeScoreLetters()
    {
      char[] ThreePointArray = {'B', 'C', 'M', 'P'};
      foreach(char pointLetter in ThreePointArray)
      {
        foreach (char userLetter in LettersArray)
        {
          if (pointLetter == userLetter)
          {
            Counter += 3;
          }
        }
      }
      return Counter;
    }
    public int FourScoreLetters()
    {
      char[] FourPointArray = {'F', 'H', 'V', 'W', 'Y'};
      foreach(char pointLetter in FourPointArray)
      {
        foreach (char userLetter in LettersArray)
        {
          if (pointLetter == userLetter)
          {
            Counter += 4;
          }
        }
      }
      return Counter;
    }
    public int FiveScoreLetters()
    {
      char[] FivePointArray = {'K'};
      foreach(char pointLetter in FivePointArray)
      {
        foreach (char userLetter in LettersArray)
        {
          if (pointLetter == userLetter)
          {
            Counter += 5;
          }
        }
      }
      return Counter;
    }

    public int EightScoreLetters()
    {
      char[] EightPointArray = {'J', 'X'};
      foreach(char pointLetter in EightPointArray)
      {
        foreach (char userLetter in LettersArray)
        {
          if (pointLetter == userLetter)
          {
            Counter += 8;
          }
        }
      }
      return Counter;
    }
    
    public int TenScoreLetters()
    {
      char[] TenPointArray = {'Q', 'Z'};
      foreach(char pointLetter in TenPointArray)
      {
        foreach (char userLetter in LettersArray)
        {
          if (pointLetter == userLetter)
          {
            Counter += 10;
          }
        }
      }
      return Counter;
    }

    public void ScoreWord()
    {
      OneScoreLetters();
      TwoScoreLetters();
      ThreeScoreLetters();
      FourScoreLetters();
      FiveScoreLetters();
      EightScoreLetters();
      TenScoreLetters();
    }
  }
}