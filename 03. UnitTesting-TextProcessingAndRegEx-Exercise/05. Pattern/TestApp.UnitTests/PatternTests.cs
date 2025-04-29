using NUnit.Framework;

namespace TestApp.UnitTests;

public class PatternTests
{

    [TestCase("asd", 2, "aSdaSd")]
    [TestCase("ASD", 2, "aSdaSd")]
    [TestCase("abc", 3, "aBcaBcaBc")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Arrange

        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        string input = string.Empty;
        int repetitionFactor = 999;

        // Act & Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.ArgumentException);
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        string input = "test";
        int repetitionFactor = -5;

        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor),
            Throws.ArgumentException);
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        string input = "test";
        int repetitionFactor = 0;

        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor),
            Throws.ArgumentException);
    }
}
