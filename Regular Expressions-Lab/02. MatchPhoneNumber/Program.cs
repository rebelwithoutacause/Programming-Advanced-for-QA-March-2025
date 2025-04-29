using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string pattern = @"\+359([ -])2\1\d{3}\1\d{4}\b";
        string input = Console.ReadLine();

        MatchCollection validPhones = Regex.Matches(input, pattern);

        Console.WriteLine(string.Join(", ", validPhones.Select(m => m.Value)));
    }
}