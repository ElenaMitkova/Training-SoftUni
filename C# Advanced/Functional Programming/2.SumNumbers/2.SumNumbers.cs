Func<string, int> selector = x => int.Parse(x);
int[] numbers = Console.ReadLine().Split(", ").Select(selector).ToArray();
Console.WriteLine(numbers.Length);
Console.WriteLine(numbers.Sum());