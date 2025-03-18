List<int> firstListOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
List<int> secondListOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
List<int> numbers = new List<int>();
if (firstListOfNumbers.Count > secondListOfNumbers.Count)
{
    for (int i = 0; i < secondListOfNumbers.Count; i++)
    {
        numbers.Add(firstListOfNumbers[i]);
        numbers.Add(secondListOfNumbers[i]);
    }
    for (int i = secondListOfNumbers.Count; i < firstListOfNumbers.Count; i++)
    {
        numbers.Add(firstListOfNumbers[i]);
    }
    Console.WriteLine(string.Join(' ', numbers));
    return;
}
for (int i = 0; i < firstListOfNumbers.Count; i++)
{
    numbers.Add(firstListOfNumbers[i]);
    numbers.Add(secondListOfNumbers[i]);
}
for (int i = firstListOfNumbers.Count; i < secondListOfNumbers.Count; i++)
{
    numbers.Add(secondListOfNumbers[i]);
}
Console.WriteLine(string.Join(' ', numbers));