using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new List<string>() { "", "", "" };
        
        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new List<string>() { "a" };
        string actual = "a -> 1";

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(actual));
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new List<string>() { "a", "abba", "aaab" };
        string actual = "a -> 6" + Environment.NewLine + "b -> 3";

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(actual));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new List<string>() { "a", "abba", "aaab", "@@ba" };
        string actual = "a -> 7" + Environment.NewLine + "b -> 4" + Environment.NewLine + "@ -> 2";

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(actual));
    }

    [Test]
    public void Test_Count_WithNumbersAndCapitalLetters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new List<string>() { "123", "ABC", "321", "CBA" };
        string actual = "1 -> 2" + Environment.NewLine +
            "2 -> 2" + Environment.NewLine +
            "3 -> 2" + Environment.NewLine +
            "A -> 2" + Environment.NewLine +
            "B -> 2" + Environment.NewLine +
            "C -> 2";

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(actual));
    }
}
