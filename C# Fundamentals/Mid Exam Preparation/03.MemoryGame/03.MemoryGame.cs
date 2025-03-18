List<string> elements = Console.ReadLine().Split(' ').ToList();
string strings;
byte moves = 1;
while ((strings = Console.ReadLine()) != "end")
{
    string[] command = strings.Split();
    int firstIndex = int.Parse(command[0]);
    int secondIndex = int.Parse(command[1]);
    if (firstIndex == secondIndex || firstIndex >= elements.Count || secondIndex >= elements.Count || firstIndex < 0 || secondIndex < 0)
    {
        elements.Insert(elements.Count / 2, $"-{moves}a");
        elements.Insert(elements.Count / 2, $"-{moves}a");
        Console.WriteLine("Invalid input! Adding additional elements to the board");
        continue;
    }
    if (elements[firstIndex] == elements[secondIndex])
    {
        Console.WriteLine($"Congrats! You have found matching elements - {elements[firstIndex]}!");
        elements.RemoveAt(Math.Max(firstIndex, secondIndex));
        elements.RemoveAt(Math.Min(firstIndex, secondIndex));
    }
    else
    {
        Console.WriteLine("Try again!");
    }
    if (elements.Count == 0)
    {
        Console.WriteLine($"You have won in {moves} turns!");
        return;
    }
    moves++;
}
Console.WriteLine("Sorry you lose :(");
Console.WriteLine(string.Join(' ', elements));