using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TestApp.UnitTests;

public class ExceptionTests
{
    private Exceptions _exceptions = null!;

    [SetUp]
    public void SetUp()
    {
        this._exceptions = new Exceptions();
    }

    // TODO: finish test
    [Test]
    public void Test_Reverse_ValidString_ReturnsReversedString()
    {
        // Arrange
        string input = "Hello";
        string expected = "olleH";
        // Act
        string result = _exceptions.ArgumentNullReverse(input);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish test
    [Test]
    public void Test_Reverse_NullString_ThrowsArgumentNullException()
    {
        // Arrange
        string input = null;
         
        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentNullReverse(input), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
    {
        decimal price = 200;
        decimal discount = 10;
        decimal expectedPrice = 180;

        //Act
        decimal result = _exceptions.ArgumentCalculateDiscount(price, discount);

        //Assert
        Assert.That(result, Is.EqualTo(expectedPrice));
    }

    // TODO: finish test
    [Test]
    public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
    {
        // Arrange
        decimal price = 200;
        decimal discount = -10;
        decimal expectedPrice = 180;
        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(price, discount), Throws.ArgumentException);
    }

    // TODO: finish test
    [Test]
    public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 100.0m;
        decimal discount = 110.0m;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => _exceptions.ArgumentCalculateDiscount(totalPrice, discount));
    }

    [Test]
    public void Test_GetElement_ValidIndex_ReturnsElement()
    {
        //Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = 2;
        int expected = 30;
        //Act
        int result = _exceptions.IndexOutOfRangeGetElement(array, index);
        //Assert
        Assert.That(result, Is.EqualTo((int)expected));
    }

    // TODO: finish test
    [Test]
    public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = -2;
        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    // TODO: finish test
    [Test]
    public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
    {
        int[] array = { 10, 20, 30, 40, 50 };
        int index = 6;
        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
    {
        //Arrange
        bool isLoggedIn = true;
        string expected = "User logged in.";
        //Act
        string result = _exceptions.InvalidOperationPerformSecureOperation(isLoggedIn);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
    {
        bool isLoggedIn = false;
        string message = "User must be logged in to perform this operation.";

        var ex = Assert.Throws<InvalidOperationException>(()
            => _exceptions.InvalidOperationPerformSecureOperation(isLoggedIn));

        Assert.That(ex.Message, Is.EqualTo(message));
    }

    [Test]
    public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
    {
        string input = "666";
        int expected = 666;

        int result = _exceptions.FormatExceptionParseInt(input);

        Assert.That(result, Is.EqualTo((int)expected));
    }

    [TestCase("tri")]

    public void Test_ParseInt_InvalidInput_ThrowsFormatException(string input)
    {


        Assert.That(() => _exceptions.FormatExceptionParseInt(input), Throws.TypeOf<FormatException>());
    }

    [Test]
    public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
    {
        Dictionary<string, int> dict = new Dictionary<string, int>()
        {
            ["one"] = 1,
            ["two"] = 2,
            ["three"] = 3,
            ["four"] = 4
            
        };
        string key = "two";
        int expected = 2;

        //Act
        int result = _exceptions.KeyNotFoundFindValueByKey(dict, key);

        Assert.That(result, Is.EqualTo(((int)expected)));
    }

    [Test]
    public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
    {
        Dictionary<string, int> dict = new Dictionary<string, int>()
        {
            ["one"] = 1,
            ["two"] = 2,
            ["three"] = 3,
            ["four"] = 4

        };
        string invalidKey = "six";
        string message = "The specified key was not found in the dictionary.";


        //Act
      
        var ex = Assert.Throws<KeyNotFoundException>(() => _exceptions.KeyNotFoundFindValueByKey(dict, invalidKey));

        Assert.That(ex.Message, Is.EqualTo(message));
    }

    [Test]
    public void Test_AddNumbers_NoOverflow_ReturnsSum()
    {
        //Arrange
        int a = 5;
        int b = 10;
        int expected = a + b;

        int result = _exceptions.OverflowAddNumbers(a, b);

        //Assert
        Assert.That(result, Is.EqualTo((int)expected));
    }

    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
    {
        int a = int.MaxValue;
        int b = 1;
        int expected = a + b;

        string message = "Arithmetic overflow occurred during addition.";

        //Act + Assert
        Assert.That(() => _exceptions.OverflowAddNumbers(a, b), Throws.TypeOf<OverflowException>());

        //Check message
        try
        {
            _exceptions.OverflowAddNumbers(a, b);
        }
        catch (OverflowException ex)
        {

            Assert.That(ex.Message, Is.EqualTo(message));
        }
    }

    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
    {
        int a = int.MinValue;
        int b = -1;
        int expected = a + b;

        string message = "Arithmetic overflow occurred during addition.";

        //Act + Assert
        Assert.That(() => _exceptions.OverflowAddNumbers(a, b), Throws.TypeOf<OverflowException>());

        //Check message
        try
        {
            _exceptions.OverflowAddNumbers(a, b);
        }
        catch (OverflowException ex)
        {

            Assert.That(ex.Message, Is.EqualTo(message));
        }
    }

    [Test]
    public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
    {
        int divident = 14;
        int divisor = 4;
        int exppected = 3;

        int result = _exceptions.DivideByZeroDivideNumbers(divident, divisor);

        Assert.That(result, Is.EqualTo(exppected));
    }

    [Test]
    public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
    {
        int divident = 14;
        int divisor = 0;

        string message = "Division by zero is not allowed.";
        try
        {
            Assert.That(() => _exceptions.DivideByZeroDivideNumbers(divident, divisor),
            Throws.TypeOf<DivideByZeroException>());
        }
        catch (DivideByZeroException ex) 
        {
            Assert.That(ex.Message, Is.EqualTo(message)); 
        }
        
        
    }

    [Test]
    public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
    {
        //Arrange
        int[] array = new int[] { 1, 2, 3, 4, 5 };
        int validIndex = 2;
        int expected = 15;

        //Act
        int result = _exceptions.SumCollectionElements(array, validIndex);

        //Assert
        Assert.That(result, Is.EqualTo((int)expected));
    }

    [Test]
    public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
    {
        //Arrange
        int[] array = null;
        int validIndex = 2;
        

       //Act + Assert

        Assert.That(() => _exceptions.SumCollectionElements(array, validIndex), 
            Throws.TypeOf<ArgumentNullException>());
    }

    [Test]
    public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
    {
        int[] array = { 1, 2, 3, };
        int invalidIndex = 6;

        Assert.That(() => _exceptions.SumCollectionElements(array, invalidIndex),
           Throws.TypeOf<IndexOutOfRangeException>());

    }

    [Test]
    public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
    {
        Dictionary<string, string> dict = new Dictionary<string, string>()
        {
            ["one"] = "1",
            ["two"] = "2",
            ["three"] = "3",
            ["four"] = "4"
        };

        string validKey = "two";
        int expected = 2;

        //Act
        int result = _exceptions.GetElementAsNumber(dict, validKey);
        
        //Assert
        Assert.AreEqual(expected, result);


    }

    [Test]
    public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
    {
        Dictionary<string, string> dict = new Dictionary<string, string>()
        {
            ["one"] = "1",
            ["two"] = "2",
            ["three"] = "3",
            ["four"] = "4"
        };

        string invalidKey = "six";
       
        //Assert
        Assert.Throws<KeyNotFoundException>(() => _exceptions.GetElementAsNumber(dict, invalidKey));
    }

    [Test]
    public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
    {
        Dictionary<string, string> dict = new Dictionary<string, string>()
        {
            ["one"] = "1Q",
            ["two"] = "2.7",
            ["three"] = "3.0",
            ["four"] = "<4!"
        };

        string validKey = "two";

        //Assert
        Assert.Throws<FormatException>(() => _exceptions.GetElementAsNumber(dict, validKey));
    }
}
