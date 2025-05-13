using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class GroupingTests
{
    // TODO: finish test
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        var input = new List <int>();
        // Act
        var result = Grouping.GroupNumbers(input);
         //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        var input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        string expected = $"Odd numbers: 1, 3, 5, 7, 9"
                         + $"{Environment.NewLine}"
                         + $"Even numbers: 2, 4, 6, 8, 0";

        // Act
        var result = Grouping.GroupNumbers(input);
        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        var input = new List<int>() { 2, 4, 6, 8, 0 };
        string expected = $"Even numbers: 2, 4, 6, 8, 0";
                        
        // Act
        var result = Grouping.GroupNumbers(input);
        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        var input = new List<int>() { 1, 3, 5, 7, 9 };
        string expected = $"Odd numbers: 1, 3, 5, 7, 9";

        // Act
        var result = Grouping.GroupNumbers(input);
        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        var input = new List<int>() { -1, -2, -3, -4, -5, -6, -7, -8, -9};
        string expected =  $"Odd numbers: -1, -3, -5, -7, -9"
                         + $"{Environment.NewLine}"
                         + $"Even numbers: -2, -4, -6, -8";

        // Act
        var result = Grouping.GroupNumbers(input);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
