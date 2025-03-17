byte numberOfLines = byte.Parse(Console.ReadLine());
const int capacity = 255;
int sum = 0;
while (numberOfLines > 0)
{
    int litres = int.Parse(Console.ReadLine());
    if (litres <= capacity - sum) sum += litres;
    else Console.WriteLine("Insufficient capacity!");
    numberOfLines--;
}
Console.WriteLine(sum);