using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class SongTests
{
    private Song _song;

    [SetUp]
    public void Setup()
    {
        this._song = new();
    }

    [Test]
    public void Test_AddAndListSongs_ReturnsAllSongs_WhenWantedListIsAll()
    {
        // Arrange
        string[] input = { "Pop_Song1_3:30",
            "Rock_Song2_4:15", 
            "Pop_Song3_3:00" };
        string expected = $"Song1{Environment.NewLine}Song2{Environment.NewLine}Song3";
        string songTypeFilter = "all";
        // Act
        string actual = _song.AddAndListSongs(input, songTypeFilter);
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndListSongs_ReturnsFilteredSongs_WhenWantedListIsSpecific()
    {
        // Arrange
        string[] input = { "Pop_Song1_3:30",
        "Rock_Song2_4:15",
        "Pop_Song3_3:00" };
        string expected = $"Song1{Environment.NewLine}Song3"; 
        string wantedList = "Pop";

        // Act
        string actual = _song.AddAndListSongs(input, wantedList);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndListSongs_ReturnsEmptyString_WhenNoSongsMatchWantedList()
    {
        // Arrange
        string[] input = { "Pop_Song1_3:30",
        "Rock_Song2_4:15",
        "Pop_Song3_3:00" };
        string expected = $"Song1{Environment.NewLine}Song3";
        string wantedList = "HardRock";

        // Act
        string actual = _song.AddAndListSongs(input, wantedList);

        // Assert
        Assert.That(actual, Is.Empty);
    }
}
