List<Person> peopleCollection = new List<Person>();
List<Product> productCollection = new List<Product>();
string[] people = Console.ReadLine().Split(new[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
string[] products = Console.ReadLine().Split(new[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
for (int i = 0; i < people.Length; i += 2)
{
    peopleCollection.Add(new Person(people[i], decimal.Parse(people[i + 1])));
}
for (int i = 0; i < products.Length; i += 2)
{
    productCollection.Add(new Product(products[i], decimal.Parse(products[i + 1])));
}
string purchase;
while ((purchase = Console.ReadLine()) != "END")
{
    string[] inputArguments = purchase.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    Person buyer = peopleCollection.FirstOrDefault(x => x.Name == inputArguments[0]);
    Product product = productCollection.FirstOrDefault(y => y.Name == inputArguments[1]);
    buyer.BuyProduct(product);
}
foreach (var element in peopleCollection)
{
    Console.WriteLine(element);
}
class Person
{
    public Person(string name, decimal money)
    {
        Name = name;
        Money = money;
        BagOfProducts = new List<string>();
    }
    public string Name { get; set; }
    public decimal Money { get; set; }
    public List<string> BagOfProducts { get; set; }
    public void BuyProduct(Product product)
    {
        if (product.Cost > Money)
        {
            Console.WriteLine($"{Name} can't afford {product.Name}");
        }
        else
        {
            Console.WriteLine($"{Name} bought {product.Name}");
            Money -= product.Cost;
            BagOfProducts.Add(product.Name);
        }
    }
    public override string ToString()
    {
        string person = $"{Name} - ";
        if (BagOfProducts.Count == 0)
        {
            person += "Nothing bought";
        }
        else
        {
            person += string.Join(", ", BagOfProducts);
        }
        return person;
    }
}
class Product
{
    public Product(string name, decimal cost)
    {
        Name = name;
        Cost = cost;
    }
    public string Name { get; set; }
    public decimal Cost { get; set; }
}