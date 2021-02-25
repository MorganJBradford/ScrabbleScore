using System;
using ScrabbleScore.Models;

namespace ScrabbleScore
{

  public class Program
  {

    public static void Main()
    {
      Console.WriteLine("Hey you stupid asshole enter a word to get it's scrabble score!");
      string word = Console.ReadLine();
      ScrabbleWord userWord = new ScrabbleWord(word);
      userWord.ScoreWord();
      Console.WriteLine($"{word} equals {userWord.Counter} points");
    }
  }
}