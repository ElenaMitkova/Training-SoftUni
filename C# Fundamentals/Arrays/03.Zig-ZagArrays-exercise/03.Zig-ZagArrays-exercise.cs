int counter = int.Parse(Console.ReadLine());
int[] first = new int[counter];
int i = 0, j = 0, count = 0;
int[] second = new int[counter];
while (counter > 0)
{
    int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    if(count % 2 == 0)
    {
        first[i] = numbers[0];
        second[j] = numbers[1];
    }
    else
    {
        first[i] = numbers[1];
        second[j] = numbers[0];
    }
    counter--;
    count++;
    i++;
    j++;
}
Console.WriteLine(string.Join(" ",first));
Console.WriteLine(string.Join(" ",second));