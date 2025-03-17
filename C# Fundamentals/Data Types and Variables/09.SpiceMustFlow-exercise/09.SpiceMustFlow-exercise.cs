int yelts = int.Parse(Console.ReadLine());
int drops = 10;
int consumers = 26;
int counter = 0;
int yeltsCopy = yelts;
int sum = 0;
while (yelts >= 100)
{
    counter++;
    yeltsCopy -= consumers;
    sum += yeltsCopy;
    yelts -= drops;
    yeltsCopy = yelts;
}
if (sum < 26)
{
    Console.WriteLine(counter);
    Console.WriteLine(sum);
}
else
{
    Console.WriteLine(counter);
    Console.WriteLine(sum - consumers);
}