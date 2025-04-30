using System;
using System.Collections.Generic;
using System.Linq;

List<string> words = Console.ReadLine()
                            .Split(' ')
                            .Select(w => w.ToLower())
                            .ToList();

Dictionary<string, int> numbersAndCount = new Dictionary<string, int>();

for (int i = 0; i < words.Count; i++)
{
    string key = words[i];

    if (numbersAndCount.ContainsKey(key))
    {
        numbersAndCount[key]++;
    }
    else 
    {
        numbersAndCount.Add(key, 1);
    }
}

foreach (var item in numbersAndCount)
{
    if (item.Value % 2 != 0)
    {
        Console.Write(item.Key + " ");
    }
}