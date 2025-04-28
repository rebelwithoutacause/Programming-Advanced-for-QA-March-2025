using System.Text;

//Version 1

string input = Console.ReadLine();

StringBuilder digits = new StringBuilder();
StringBuilder letters = new StringBuilder();
StringBuilder otherCharacters = new StringBuilder();

foreach (char c in input) 
{
    if (char.IsDigit(c))
    {
        digits.Append(c);
    }
    else if (char.IsLetter(c)) 
    {
    letters.Append(c);
    }
    else otherCharacters.Append(c);
}
Console.WriteLine(digits.ToString());
Console.WriteLine(letters.ToString());
Console.WriteLine(otherCharacters.ToString());

//Version 2

//string input = Console.ReadLine();

//string digits = "";
//string letters = "";
//string otherCharacters = "";

//foreach (char c in input)
//{
//    if (char.IsDigit(c))
//    {
//        digits += c;
//    }
//    else if (char.IsLetter(c))
//    {
//        letters += c;
//    }
//    else
//    {
//        otherCharacters += c;
//    }
//}

//Console.WriteLine(digits);
//Console.WriteLine(letters);
//Console.WriteLine(otherCharacters)