﻿double food = double.Parse(Console.ReadLine()) * 1000;
double hay = double.Parse(Console.ReadLine()) * 1000;
double cover = double.Parse(Console.ReadLine()) * 1000;
double gineasWeight = double.Parse(Console.ReadLine()) * 1000;
for (int i = 1; i <= 30; i++)
{
    food -= 300;
    if (i % 2 == 0)
    {
        hay -= food * 0.05;
    }
    if (i % 3 == 0)
    {
        cover -= gineasWeight / 3;
    }
    if (food <= 0 || hay <= 0 || cover <= 0)
    {
        Console.WriteLine("Merry must go to the pet store!");
        return;
    }
}
Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food / 1000:F2}, Hay: {hay / 1000:F2}, Cover: {cover / 1000:F2}.");