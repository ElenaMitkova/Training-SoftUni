﻿int packsPens = int.Parse(Console.ReadLine());
int packsMarkers = int.Parse(Console.ReadLine());
int litres = int.Parse(Console.ReadLine());
double percentDiscount = double.Parse(Console.ReadLine()) / 100;
double sumForPens = packsPens * 5.80;
double sumForMarkers = packsMarkers * 7.20;
double sumForLitres = litres * 1.20;
double sum = sumForPens + sumForMarkers + sumForLitres;
double result = sum - (sum * percentDiscount);
Console.WriteLine(result);