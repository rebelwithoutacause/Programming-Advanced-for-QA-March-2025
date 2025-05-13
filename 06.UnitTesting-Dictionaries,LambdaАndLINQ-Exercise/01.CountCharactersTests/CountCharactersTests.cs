using NUnit.Framework;

using System;
using System.Collections.Generic;
using static NUnit.Framework.Constraints.Tolerance;

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

    // TODO: finish test
    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new() {""};
        // Act
        string result = CountCharacters.Count(input);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "A" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        string expected = "A -> 1";

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "A", "B", "C" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        string expected =
            $"A -> 1{Environment.NewLine}" +
            $"B -> 1{Environment.NewLine}" +
            "C -> 1";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "?", "!" };

        // Act
        string result = CountCharacters.Count(input);
        string expected =
            $"? -> 1{Environment.NewLine}" +
            $"! -> 1";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
