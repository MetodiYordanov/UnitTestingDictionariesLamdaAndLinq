using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class GroupingTests
{
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> input = new List<int>();
        string actual = string.Empty;

        // Act
        string result = Grouping.GroupNumbers(input);
        
        // Assert
        Assert.That(result, Is.EqualTo(actual));
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {

        // Arrange
        List<int> input = new List<int>() { 2, 1, 3, 4 };
        string actual = "Even numbers: 2, 4" + Environment.NewLine + "Odd numbers: 1, 3";

        // Act
        string result = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(actual));
    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new List<int>() { 2, 4 };
        string actual = "Even numbers: 2, 4";

        // Act
        string result = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(actual));
    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new List<int>() { 1, 3 };
        string actual = "Odd numbers: 1, 3";

        // Act
        string result = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(actual));
    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new List<int>() { -2, -1, -3, -4 };
        string actual = "Even numbers: -2, -4" + Environment.NewLine + "Odd numbers: -1, -3";

        // Act
        string result = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(actual));
    }
}
