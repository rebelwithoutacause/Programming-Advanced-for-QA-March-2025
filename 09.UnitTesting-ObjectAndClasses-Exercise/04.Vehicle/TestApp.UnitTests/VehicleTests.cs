using NUnit.Framework;

using System;

using TestApp.Vehicle;

namespace TestApp.UnitTests;

public class VehicleTests
{
    // TODO: write the setup method
    private Vehicles _vehicle;

    [SetUp]
    public void SetUp()
    {
        _vehicle = new Vehicles();
    }
    
    [Test]
    public void Test_AddAndGetCatalogue_ReturnsSortedCatalogue()
    {
        // Arrange
        string[] input = new string[]
        {
            "car/Ford/Focus/120",
            "car/Toyota/Camry/150",
            "Truck/Volvo/VNL/500"
        };

        string expected = $"Cars:{Environment.NewLine}"
            + $"Ford: Focus - 120hp{Environment.NewLine}"
            + $"Toyota: Camry - 150hp{Environment.NewLine}"
            + $"Trucks:{Environment.NewLine}"
            + $"Volvo: VNL - 500kg";

        // Act
        string result = _vehicle.AddAndGetCatalogue(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndGetCatalogue_ReturnsEmptyCatalogue_WhenNoDataGiven()
    {
        // Arrange
        string[] input = Array.Empty<string>();
        string expected = $"Cars:{Environment.NewLine}Trucks:";

        // Act
        string actual = this._vehicle.AddAndGetCatalogue(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
