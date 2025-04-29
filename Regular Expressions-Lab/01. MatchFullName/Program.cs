using System.Text.RegularExpressions;

string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";

string input = Console.ReadLine();

MatchCollection regexMatches = Regex.Matches(input, pattern);

Console.WriteLine(string.Join(" ", regexMatches));