﻿int counter = int.Parse(Console.ReadLine());
List<string> products = new List<string>();
for (int i = 0; i < counter; i++)
{
    products.Add(Console.ReadLine());
}
products.Sort();
for (int i = 0;i < products.Count;i++)
{
    Console.WriteLine($"{i + 1}.{products[i]}");
}