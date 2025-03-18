string[] input = Console.ReadLine().Split().ToArray();
Random random = new Random();
for (int i = 0; i < input.Length; i++)
{
    string current = input[i];
    int randomIndex = random.Next(0, input.Length);
    input[i] = input[randomIndex];
    input[randomIndex] = current;
}
foreach (string s in input)
{
    Console.WriteLine(s);
}