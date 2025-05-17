using NUnit.Framework;

using System;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.UnitTests;

public class PlanetTests
{
    // TODO: finish test
    [Test]
    public void Test_CalculateGravity_ReturnsCorrectCalculation()
    { 
       // Arrange
        Planet earth = new("Earth", 12742, 149600000, 1);
        double mass = 1000;
        double expectedGravity = mass * 6.67430e-11 / Math.Pow(earth.Diameter / 2, 2);

        // Act
        double actual = earth.CalculateGravity(mass);
        // Assert
        Assert.That(actual, Is.EqualTo(expectedGravity));
    }

    [Test]
    public void Test_GetPlanetInfo_ReturnsCorrectInfo()
    {
        // Arrange
        Planet jupiter = new Planet("Jupiter", 139_820, 778_500_000, 95);
        string expected =
            "Planet: Jupiter" + Environment.NewLine +
            "Diameter: 139820 km" + Environment.NewLine +
            "Distance from the Sun: 778500000 km" + Environment.NewLine +
            "Number of Moons: 95";

        // Act
        string actual = jupiter.GetPlanetInfo();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
