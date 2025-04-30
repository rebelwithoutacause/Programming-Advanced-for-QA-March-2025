using System.Diagnostics.Tracing;

int n = int.Parse(Console.ReadLine());

Dictionary<string, List<string>> words = new();


for (int i = 0; i<n; i++) 
{
    string currentWord = Console.ReadLine();
    string synonym = Console.ReadLine();

    if (!words.ContainsKey(currentWord)) 
    {
        words.Add(currentWord, new List<string>());
    }

    words[currentWord].Add(synonym);
}
foreach (var kvp in words)
{
    Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
}