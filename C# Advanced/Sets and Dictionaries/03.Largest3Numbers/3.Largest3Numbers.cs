int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] sorted = numbers.OrderByDescending(number => number).Take(3).ToArray();
Console.WriteLine(string.Join(' ', sorted));