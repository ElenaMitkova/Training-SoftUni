Dictionary<int, int> numbersCount = new Dictionary<int, int>();
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    if (!numbersCount.ContainsKey(number))
    {
        numbersCount[number] = 0;
    }
    numbersCount[number]++;
}
int numberEven = numbersCount.Single(x => x.Value % 2 == 0).Key;
Console.WriteLine(numberEven);