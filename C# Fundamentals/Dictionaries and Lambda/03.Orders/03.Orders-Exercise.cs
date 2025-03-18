Dictionary<string, Product> products = new Dictionary<string, Product>();
string input;
while ((input = Console.ReadLine()) != "buy")
{
    string[] arguments = input.Split();
    if (!products.ContainsKey(arguments[0]))
    {
        products.Add(arguments[0], new Product());
    }
    products[arguments[0]].Price = decimal.Parse(arguments[1]);
    products[arguments[0]].Quantity += int.Parse(arguments[2]);
}
foreach (var pair in products)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value.Quantity * pair.Value.Price}");
}
class Product
{
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}