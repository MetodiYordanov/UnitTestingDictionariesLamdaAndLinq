using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();
        string actual = string.Empty;

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo(actual));
    }

    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = { "banana 1.25 5", "banana 1.10 10" };
        string actual = "banana -> 16.50";

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo(actual));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = { "banana 2 5", "banana 1 10" };
        string actual = "banana -> 15.00";

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo(actual));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = { "coffee 0.54 1.3", "water 1 0.75" };
        string actual = $"coffee -> 0.70{Environment.NewLine}water -> 0.75";

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo(actual));
    }
}
