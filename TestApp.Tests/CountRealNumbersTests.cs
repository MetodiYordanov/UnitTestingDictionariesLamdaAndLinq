using NUnit.Framework;

using System;
using System.Text;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] input = new int[0];
        string actual = string.Empty;

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(actual));
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 1 };

        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"1 -> 1");
        string actual = sb.ToString().Trim();

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(actual));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 1, 2, 3, 1, 2, 1, 3, 2 };

        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"1 -> 3");
        sb.AppendLine($"2 -> 3");
        sb.AppendLine($"3 -> 2");
        string actual = sb.ToString().Trim();

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(actual));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { -1, -2, -3, -1, -2, -1, -3, -2 };

        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"-3 -> 2");
        sb.AppendLine($"-2 -> 3");
        sb.AppendLine($"-1 -> 3");
        string actual = sb.ToString().Trim();

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(actual));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 0, 0, 0, 0, 0 };

        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"0 -> 5");
        string actual = sb.ToString().Trim();

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(actual));
    }
}
