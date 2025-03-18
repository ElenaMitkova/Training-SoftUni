List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
List<int> bombList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
int bomb = bombList[0];
int bombPower = bombList[1];
while (numbers.Contains(bomb))
{
    int index = numbers.IndexOf(bomb);
    int leftIndex = Math.Max(0, index - bombPower);
    int rightIndex = Math.Min(numbers.Count - 1, index + bombPower);
    int range = rightIndex - leftIndex + 1;
    numbers.RemoveRange(leftIndex, range);
}
Console.WriteLine(numbers.Sum());