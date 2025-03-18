int n = int.Parse(Console.ReadLine());
string[] names = Console.ReadLine().Split();
Func<string, int, bool> isValid = (word, min) => word.Sum(y => y) >= min;
int sum = 0;
for (int i = 0; i < names.Length; i++)
{
    if (isValid(names[i], n))
    {
        Console.WriteLine(names[i]);
        return;
    }
}