Dictionary<string, Action<int[]>> transformByCommand = new Dictionary<string, Action<int[]>>()
{
    ["add"] = array => TransformingArray(array, x => x + 1),
    ["multiply"] = array => TransformingArray(array, x => x * 2),
    ["subtract"] = array => TransformingArray(array, x => x - 1),
    ["print"] = array => Console.WriteLine(string.Join(' ', array)),
};
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
string command;
while ((command = Console.ReadLine()) != "end")
{
    transformByCommand[command](numbers);
}
void TransformingArray(int[] numbers, Func<int, int> transform)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = transform(numbers[i]);
    }
}