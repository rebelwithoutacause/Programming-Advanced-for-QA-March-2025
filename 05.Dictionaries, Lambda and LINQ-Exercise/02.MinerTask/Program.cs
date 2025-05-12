Dictionary<string, int> mineResources = new();

string resourceName = Console.ReadLine();

while(resourceName != "stop") 
{
    int quantity = int.Parse(Console.ReadLine());

    if (!mineResources.ContainsKey(resourceName)) 
    {
        mineResources.Add(resourceName, 0);
    }
    
    mineResources[resourceName] += quantity;

    resourceName = Console.ReadLine();
}
foreach (var kvp in mineResources)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}