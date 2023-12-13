using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class MinerTests
{
    [Test]
    public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = new string[0];
        string actual = string.Empty;

        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.EqualTo(actual));
    }

    [Test]
    public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = { "Gold 8", "SILVER 30" };
        string actual = $"gold -> 8{Environment.NewLine}silver -> 30";
        
        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.EqualTo(actual));
    }

    [Test]
    public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
    {
        // Arrange
        string[] input = { "gold 8", "silver 30" };
        string actual = $"gold -> 8{Environment.NewLine}silver -> 30";

        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.EqualTo(actual));
    }
}
