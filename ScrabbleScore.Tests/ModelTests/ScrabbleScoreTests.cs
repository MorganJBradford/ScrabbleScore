using Microsoft.VisualStudio.TestTools.UnitTesting;
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
