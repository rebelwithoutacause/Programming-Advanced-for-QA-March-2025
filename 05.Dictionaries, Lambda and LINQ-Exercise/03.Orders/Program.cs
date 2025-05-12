Dictionary<string, double[]> products = new();

string productInput = Console.ReadLine();

while(productInput != "buy") 
{
    string[] productTokens = productInput.Split(' ');
    
    string productName = productTokens[0];
    double productPrice = double.Parse(productTokens[1]);
    double productQuantity = double.Parse(productTokens[2]);

    if (!products.ContainsKey(productName)) 
    {
        products.Add(productName, new double[2]);
    }
    
    products[productName][0] = productPrice;
    products[productName][1] += productQuantity;

    productInput = Console.ReadLine();
}

foreach (var kvp in products)
{
    double productPrice = kvp.Value[0];
    double productQuantity = kvp.Value[1];
    double totalPrice = productPrice * productQuantity;

    Console.WriteLine($"{kvp.Key} -> {totalPrice:F2}");
}