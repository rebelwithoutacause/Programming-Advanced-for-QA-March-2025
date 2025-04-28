string textToRemove = Console.ReadLine();
string text = Console.ReadLine();

while (text.IndexOf(textToRemove) != -1) 
{
    int startIndex = text.IndexOf(textToRemove);

    text = text.Remove(startIndex, textToRemove.Length);

}

Console.WriteLine(text);