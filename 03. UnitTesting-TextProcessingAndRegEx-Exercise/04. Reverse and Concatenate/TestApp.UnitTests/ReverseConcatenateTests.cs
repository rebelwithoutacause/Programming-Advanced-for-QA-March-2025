using NUnit.Framework;

using System;
using System.Linq;

namespace TestApp.UnitTests;

public class ReverseConcatenateTests
{
    // TODO: finish the test
    [Test]
    public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] inputData = Array.Empty<string>();
        string expected = string.Empty;
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(inputData);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish the test
    [Test]
    public void Test_ReverseAndConcatenateStrings_SingleString_ReturnsSameString()
    {
        // Arrange
        string[] inputData = new string[] { "brown" };
        string expected = "brown";
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(inputData);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_MultipleStrings_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[] inputData = new string[] { " brown", "lazy", "dog" };
        string expected = "doglazy brown";
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(inputData);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_NullInput_ReturnsEmptyString()
    {
        string[] inputData = null;
        string expected = string.Empty;
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(inputData);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_WhitespaceInput_ReturnsConcatenatedString()
    {
        string[] inputData = new[] {"dog", " ", "lazy", " ", "brown"};
        string expected = "brown lazy dog";
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(inputData);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_LargeInput_ReturnsReversedConcatenatedString()
    {
        string[] inputData = new[] { "a", " ", "b", " ", "c", " ", "d" };
        string expected = "d c b a";
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(inputData);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
