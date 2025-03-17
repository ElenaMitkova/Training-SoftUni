int counter = int.Parse(Console.ReadLine());
long[] numbers = new long[counter];
int count = 0;
while (counter > 0)
{
    string name = Console.ReadLine();
    long vowelSum = 0;
    long consonantSum = 0;
    for (int i = 0; i < name.Length; i++)
    {
        if ("aeiouAEIOU".Contains(name[i]))
        {
            vowelSum += name[i] * name.Length;
        }
        else
        {
            consonantSum += name[i] / name.Length;
        }
    }
    numbers[count] = vowelSum + consonantSum;
    counter--;
    count++;
}
Array.Sort(numbers);
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}