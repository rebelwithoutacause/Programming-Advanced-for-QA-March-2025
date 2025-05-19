using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int totalSum = 0;

        foreach (string element in input)
        {
            try
            {
                int number = int.Parse(element);
                totalSum += number;
            }
            catch (FormatException)
            {
                Console.WriteLine($"The element '{element}' is in wrong format!");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"The element '{element}' is out of range!");
            }
            finally
            {
                Console.WriteLine($"Element '{element}' processed - current sum: {totalSum}");
            }
        }

        Console.WriteLine($"The total sum of all integers is: {totalSum}");
    }
}