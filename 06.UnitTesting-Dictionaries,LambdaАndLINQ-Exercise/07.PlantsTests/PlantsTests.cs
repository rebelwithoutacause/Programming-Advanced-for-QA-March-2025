using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();
        // Act
        string result = Plants.GetFastestGrowing(input);
        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] plants = new string[] { "tulip" };
        string expected = $"Plants with 5 letters:"
            + Environment.NewLine
            + "tulip";
        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] plants = new string[] {"rose", "tulip", "orchid" };
        string expected =
    "Plants with 4 letters:"
    + Environment.NewLine
    + "rose"
    + Environment.NewLine
    + "Plants with 5 letters:"
    + Environment.NewLine
    + "tulip"
    + Environment.NewLine
    + "Plants with 6 letters:"
    + Environment.NewLine
    + "orchid";

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] plants = new string[] { "roSe", "TuLip", "orchID" };
        string expected =
    "Plants with 4 letters:"
    + Environment.NewLine
    + "roSe"
    + Environment.NewLine
    + "Plants with 5 letters:"
    + Environment.NewLine
    + "TuLip"
    + Environment.NewLine
    + "Plants with 6 letters:"
    + Environment.NewLine
    + "orchID";

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
