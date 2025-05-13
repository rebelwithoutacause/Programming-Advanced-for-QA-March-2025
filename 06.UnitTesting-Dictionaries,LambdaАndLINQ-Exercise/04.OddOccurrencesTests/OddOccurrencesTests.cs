using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        //Arrange
        string[] input = Array.Empty<string>();
        //Act
        string actual = OddOccurrences.FindOdd(input);
        //Assert
        Assert.That(actual, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        //Arrange
        string[] input = new string[] { "brain", "brain", "grock", "grock" };

        //Act
        string actual = OddOccurrences.FindOdd(input);
        //Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        //Arrange
        string[] input = new string[] { "stock" };
        string expected = "stock";

        //Act
        string actual = OddOccurrences.FindOdd(input);
        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        //Arrange
        string[] input = new string[] { "brain", "brain", "brain" };
        string expected = "brain";

        //Act
        string actual = OddOccurrences.FindOdd(input);
        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        //Arrange
        string[] input = new string[] { "brAin", "braiN", "Brain", "break", "Break", "breaK" };
        string expected = $"{ "brain break" }" ;

        //Act
        string actual = OddOccurrences.FindOdd(input);
        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
