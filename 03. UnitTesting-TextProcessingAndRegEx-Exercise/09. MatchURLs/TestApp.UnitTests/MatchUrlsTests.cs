using NUnit.Framework;

using System.Collections.Generic;
using static System.Net.WebRequestMethods;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        // Arrange
        string text = "";
        List<string> expected = new();

        // Act
        List<string> actual = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        // Arrange
        string text = "Zero urls found.";
        List<string> expected = new();
        // Act
        List<string> result = MatchUrls.ExtractUrls(text);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        // Arrange
        string text = @"https://wwww.onlineshop.commmm?searchTerm=gotvarsk%20pechka&orderby=date";
        List<string> expected = new()
        {
            "https://wwww.onlineshop.commmm?searchTerm=gotvarsk%20pechka&orderby=date"
        };

        // Act
        List<string> actual = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        // Arrange
        string text = @"https://www.beer.com
                        https://horrormovies.com
                        https://rockandroll.org";
        List<string> expected = new()
        {
            "https://www.beer.com",
            "https://horrormovies.com",
            "https://rockandroll.org"

        };

        // Act
        List<string> actual = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
        Assert.That(actual.Count, Is.EqualTo(expected.Count));
        Assert.That(actual, Is.Not.Empty);
        Assert.That(actual, Has.Exactly(3).Items);
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        // Arrange
        string text = "\"https://wwww.onlineshop.commmm?searchTerm=gotvarsk%20pechka&orderby=date\"";
        List<string> expected = new()
        {
            "https://wwww.onlineshop.commmm?searchTerm=gotvarsk%20pechka&orderby=date"
        };

        // Act
        List<string> actual = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }
}
