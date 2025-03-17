int counter = int.Parse(Console.ReadLine());
long fibonaci1 = 1;
long fibonaci2 = 1;
if (counter == 1 )
{
    Console.WriteLine(fibonaci1);
    return;
}
long fibonaciN = 0;
for (int i = 2; i < counter; i++)
{
    fibonaciN = fibonaci1 + fibonaci2;
    fibonaci1 = fibonaci2;
    fibonaci2 = fibonaciN;
}
Console.WriteLine(fibonaciN);