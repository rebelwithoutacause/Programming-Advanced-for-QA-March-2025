using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class StudentTests
{
    private Student _student;

    [SetUp]
    public void SetUp()
    {
        this._student = new();
    }

    // TODO: finish test
    [Test]
    public void Test_AddAndGetByCity_ReturnsStudentsInCity_WhenCityExists()
    {
        // Arrange
        string[] input = { "John Doe 25 Sofia",
            "Jane Smith 22 Varna",
            "Alice Johnson 20 Sofia" };
        string expected = $"John Doe is 25 years old" 
            +$".{Environment.NewLine}Alice Johnson is 20 years old.";
        string filterTown = "Sofia";

        // Act
        string actual = this._student.AddAndGetByCity(input, filterTown);
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndGetByCity_ReturnsEmptyString_WhenCityDoesNotExist()
    {
        // Arrange
        string[] input = { "John Doe 25 Sofia",
            "Jane Smith 22 Varna",
            "Alice Johnson 20 Sofia" };
        string expected = string.Empty;
        string filterTown = "Kazanlak";

        // Act
        string actual = this._student.AddAndGetByCity(input, filterTown);
        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_AddAndGetByCity_ReturnsEmptyString_WhenNoStudentsGiven()
    {
        // Arrange
        string[] input = Array.Empty<string>();
        string expected = string.Empty;
        string filterTown = "Plovdiv";

        // Act
        string actual = this._student.AddAndGetByCity(input, filterTown);

        // Assert
        Assert.That(actual, Is.Empty);
    }
}
