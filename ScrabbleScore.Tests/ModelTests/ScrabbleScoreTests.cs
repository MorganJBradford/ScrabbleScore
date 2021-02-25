using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ScrabbleScore.Models;
using System;


namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScrabbleWordTests
  {
    // Test methods go here
    [TestMethod]
public void ScrabbleWordConstructor_CreatesInstanceofWord_True()
// NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
{
  // any necessary logic to prep for test; instantiating new classes, etc.
  ScrabbleWord newWord = new ScrabbleWord("parascope");
  Assert.AreEqual(typeof(ScrabbleWord), newWord.GetType());
}

    [TestMethod]
    public void LettersArray_CreatesAnArrayOfWordLetters_True()
    {
      ScrabbleWord newWord = new ScrabbleWord("pArA");
      char[] testArray = {'P', 'A', 'R', 'A'};
      CollectionAssert.AreEqual(newWord.LettersArray, testArray);
    }

    [TestMethod]
    public void ScrabbleWord_DisplaysPtValueOf1PtWords_True()
    {
      ScrabbleWord newWord = new ScrabbleWord("apples");
      newWord.OneScoreLetters();
      Assert.AreEqual(4, newWord.Counter);
    }
    [TestMethod]
    public void ScrabbleWord_DisplaysPtValueOf2PtWords_True()
    {
      ScrabbleWord newWord = new ScrabbleWord("dog");
      newWord.TwoScoreLetters();
      Assert.AreEqual(4, newWord.Counter);
    }
    [TestMethod]
    public void ScrabbleWord_DisplaysPtValueOf3PtWords_True()
    {
      ScrabbleWord newWord = new ScrabbleWord("batch");
      newWord.ThreeScoreLetters();
      Assert.AreEqual(6, newWord.Counter);
    }
    [TestMethod]
    public void ScrabbleWord_DisplaysPtValueOf4PtWords_True()
    {
      ScrabbleWord newWord = new ScrabbleWord("fart");
      newWord.FourScoreLetters();
      Assert.AreEqual(4, newWord.Counter);
    }
    [TestMethod]
    public void ScrabbleWord_DisplaysPtValueOf5PtWords_True()
    {
      ScrabbleWord newWord = new ScrabbleWord("kill");
      newWord.FiveScoreLetters();
      Assert.AreEqual(5, newWord.Counter);
    }
    [TestMethod]
    public void ScrabbleWord_DisplaysPtValueOf8PtWords_True()
    {
      ScrabbleWord newWord = new ScrabbleWord("jax");
      newWord.EightScoreLetters();
      Assert.AreEqual(16, newWord.Counter);
    }

    [TestMethod]
    public void ScrabbleWord_DisplaysPtValueOf10PtWords_True()
    {
      ScrabbleWord newWord = new ScrabbleWord("quiz");
      newWord.TenScoreLetters();
      Assert.AreEqual(20, newWord.Counter);
    }
    
  }
}
// test1 correctly takes input from user
// test2 correctly splits users input into an array of letters
// test2.5 correctly ensures constructor is created
// test3 correctly loops through users letter array and outputs correct value for 1 pt words
// test4 correctly loops through users letter array and outputs correct value for 2 pt words
// test5 correctly loops through users letter array and outputs correct value for 3 pt words
// test6 correctly adds score from all previous loops
// test7 outputs users word and score
