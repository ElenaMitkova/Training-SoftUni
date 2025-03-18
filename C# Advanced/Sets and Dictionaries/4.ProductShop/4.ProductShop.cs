Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();
string command;
while ((command = Console.ReadLine()) != "Revision")
{
    string[] arguments = command.Split(", ");
    string shopName = arguments[0];
    string product = arguments[1];
    double productPrice = double.Parse(arguments[2]);
    if (!shops.ContainsKey(shopName))
    {
        shops.Add(shopName, new Dictionary<string, double>());
    }
    shops[shopName].Add(product, productPrice);
}
shops = shops.OrderBy(shop => shop.Key).ToDictionary(shop => shop.Key, shop => shop.Value);
foreach ((string shop, Dictionary<string, double> products) in shops)
{
    Console.WriteLine($"{shop}->");
    foreach ((string name, double price) in products)
    {
        Console.WriteLine($"Product: {name}, Price: {price}");
    }
}