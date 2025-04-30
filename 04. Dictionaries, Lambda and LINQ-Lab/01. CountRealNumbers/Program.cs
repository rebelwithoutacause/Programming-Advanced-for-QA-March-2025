List<int> numbers = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToList();

SortedDictionary<int, int> numberWithOccurrences = new();

foreach(var number in numbers) 
{
    if (numberWithOccurrences.ContainsKey(number)) 
    {
        numberWithOccurrences[number] += 1;
    }
    else 
    {
        numberWithOccurrences.Add(number, 1);
    }
}

foreach(KeyValuePair<int, int> kvp in numberWithOccurrences) 
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}