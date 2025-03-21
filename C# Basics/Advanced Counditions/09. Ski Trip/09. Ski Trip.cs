﻿int days = int.Parse(Console.ReadLine());
string roomType = Console.ReadLine();
string evaluation = Console.ReadLine();


int nights = days - 1;
double price = 0;
if (roomType == "room for one person") price = 18;
else if (roomType == "apartment")
{
    price = 25;

    if (nights < 10) price *= 0.7;
    else if (nights <= 15) price *= 0.65;
    else price *= 0.5;
}
else if (roomType == "president apartment")
{
    price = 35;

    if (nights < 10) price *= 0.9;
    else if (nights <= 15) price *= 0.85;
    else price *= 0.8;
}

double totalCosts = nights * price;
if (evaluation == "positive") totalCosts *= 1.25;
else totalCosts *= 0.9;

Console.WriteLine($"{totalCosts:f2}");