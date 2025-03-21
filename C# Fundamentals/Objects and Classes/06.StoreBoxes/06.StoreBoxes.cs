﻿List<Box> boxes = new List<Box>();
string command;
while ((command = Console.ReadLine()) != "end")
{
    string[] tokens = command.Split();
    Box box = new Box { SerialNumber = tokens[0], Item = new Item(tokens[1], decimal.Parse(tokens[3])), ItemQuantity = int.Parse(tokens[2]) };
    boxes.Add(box);
}
List<Box> orderedBoxes = boxes.OrderByDescending(box => box.Price).ToList();
foreach (Box box in orderedBoxes)
{
    Console.WriteLine(box.SerialNumber);
    Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
    Console.WriteLine($"-- ${box.Price:f2}");
}
class Item
{
    public Item(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
class Box
{
    public string SerialNumber { get; set; }
    public Item Item { get; set; }
    public int ItemQuantity { get; set; }
    public decimal Price
    {
        get
        {
            return this.ItemQuantity * this.Item.Price;
        }
    }
}