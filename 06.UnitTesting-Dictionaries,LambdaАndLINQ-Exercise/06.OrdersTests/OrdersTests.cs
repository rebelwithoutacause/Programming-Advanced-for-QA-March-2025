using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        //Arrange
        string[] input = Array.Empty<string>();
        string expected = string.Empty;
        //Act
        string result = Orders.Order(input);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish test
    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[] 
        {
        "apple 1.25 4.38",
        "banana 1.50 8.73",
        "orange 2.19 1.25"
        };
        string expected = $"apple -> 5.48{Environment.NewLine}banana -> 13.10{Environment.NewLine}orange -> 2.74";
        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[]
        {
        "apple 1.25 4.38",
        "banana 1.50 8.73",
        "orange 2.19 1.25"
        };
        string expected = $"apple -> 5.48{Environment.NewLine}banana -> 13.10{Environment.NewLine}orange -> 2.74";
        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[]
        {
        "apple 1.25 4.38",
        "banana 1.50 8.73",
        "orange 2.19 1.25"
        };
        string expected = $"apple -> 5.48{Environment.NewLine}banana -> 13.10{Environment.NewLine}orange -> 2.74";
        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
