using NUnit.Framework;

namespace TestApp.UnitTests;

public class SubstringTests
{
    
    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromMiddle()
    {
        // Arrange
        string toRemove = "lazy";
        string input = "brown lazy dog";
        string expected = "brown dog";

        // Act
        string actual = Substring.RemoveOccurrences(toRemove, input);
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromStart()
    {

        // Arrange
        string toRemove = "brown";
        string input = "brown lazy dog";
        string expected = "lazy dog";

        // Act
        string actual = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromEnd()
    {
        // Arrange
        string toRemove = "dog";
        string input = "brown lazy dog";
        string expected = "brown lazy";

        // Act 
        string actual = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesAllOccurrences()
    {
        // Arrange
        string toRemove = "brown";
        string input = "brown lazy brown dog brown ";
        string expected = "lazy dog";

        // Act
        string actual = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}