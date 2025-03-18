int counter = int.Parse(Console.ReadLine());
for (int i = 0; i < counter; i++)
{
    Inventory inventory = new Inventory();
    Console.WriteLine(inventory.GetRandom());
}
class Inventory
{
    public string[] Phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
    public string[] Events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
    public string[] Authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
    public string[] Cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
    public string GetRandom()
    {
        Random random = new Random();
        return $"{Phrases[random.Next(0, Phrases.Length)]} {Events[random.Next(0, Events.Length)]} {Authors[random.Next(0, Authors.Length)]} – {Cities[random.Next(0, Cities.Length)]}.";
    }
}