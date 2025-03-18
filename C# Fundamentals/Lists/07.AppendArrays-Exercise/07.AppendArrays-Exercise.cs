List<string> numbers = Console.ReadLine().Split('|',StringSplitOptions.RemoveEmptyEntries).ToList();
List<string> output = new List<string>();
List<string> nums = new List<string>();
for (int i = numbers.Count -1; i >= 0; i--)
{
    output = numbers[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
    nums.AddRange(output);
}
Console.WriteLine(string.Join(' ',nums));