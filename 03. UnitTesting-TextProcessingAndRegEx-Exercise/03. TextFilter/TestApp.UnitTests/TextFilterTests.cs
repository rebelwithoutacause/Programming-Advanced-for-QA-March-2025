using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = new string[] { };
        string text = "Kurt Cobain is a rock star";
        string expected = "Kurt Cobain is a rock star";
        // Act
        string result = TextFilter.Filter(bannedWords, text);
        // Assert
        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string[] bannedWords = new string[] { "hard" };
        string text = "Kurt Cobain is a hard rock star";
        string expected = "Kurt Cobain is a **** rock star";
        // Act
        string result = TextFilter.Filter(bannedWords, text);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = Array.Empty<string>();
        string text = "Kurt Cobain is a rock star";
        string expected = "Kurt Cobain is a rock star";
        // Act
        string result = TextFilter.Filter(bannedWords, text);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string[] bannedWords = new string[] { " " };
        string text = "Kurt Cobain is a rock star";
        string expected = "Kurt*Cobain*is*a*rock*star";
        // Act
        string result = TextFilter.Filter(bannedWords, text);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}