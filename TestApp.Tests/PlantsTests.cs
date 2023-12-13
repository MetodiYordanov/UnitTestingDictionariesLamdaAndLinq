using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();
        string actual = string.Empty;

        // Act
        string result = Plants.GetFastestGrowing(input);

        // Assert
        Assert.That(result, Is.EqualTo(actual));
    }

    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] input = { "rose" };
        string actual = $"Plants with 4 letters:{Environment.NewLine}rose";

        // Act
        string result = Plants.GetFastestGrowing(input);

        // Assert
        Assert.That(result, Is.EqualTo(actual));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] input = { "rose", "iris" };
        string actual = $"Plants with 4 letters:{Environment.NewLine}rose{Environment.NewLine}iris";

        // Act
        string result = Plants.GetFastestGrowing(input);

        // Assert
        Assert.That(result, Is.EqualTo(actual));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = { "rose", "iris", "tulip" };
        string actual = $"Plants with 4 letters:{Environment.NewLine}" +
            $"rose{Environment.NewLine}iris{Environment.NewLine}" +
            $"Plants with 5 letters:{Environment.NewLine}tulip";

        // Act
        string result = Plants.GetFastestGrowing(input);

        // Assert
        Assert.That(result, Is.EqualTo(actual));
    }
}
