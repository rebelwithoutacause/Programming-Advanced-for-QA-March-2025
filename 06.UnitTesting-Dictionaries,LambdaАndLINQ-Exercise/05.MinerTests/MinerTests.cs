using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Interfaces;
using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class MinerTests
{
    [Test]
    public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
    {
        string[] input = Array.Empty<string>();

        string actual = Miner.Mine(input);

        Assert.That(actual, Is.Empty);
    }

    
    [Test]
    public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
    {
        
        // Arrange
        string[] input = new string[] { "GOLD 1", "GOLD 7", "SILVER 18", "Silver 12" };
        string expected = $"gold -> 8{Environment.NewLine}silver -> 30";
        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
    {
        // Arrange
        string[] input = new string[] { "gold 8", "silver 30", "coal 3", "copper 12" };
        string expected = $"gold -> 8{Environment.NewLine}silver -> 30{Environment.NewLine}coal -> 3{Environment.NewLine}copper -> 12";

        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
