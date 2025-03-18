int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = integers[0];
int s = integers[1];
int x = integers[2];
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
Stack<int> nums = new Stack<int>();
for (int i = 0; i < n; i++)
{
    nums.Push(numbers[i]);
}
for (int i = 0; i < s; i++)
{
    nums.Pop();
}
if (nums.Count == 0)
{
    Console.WriteLine(0);
}
else
{
    int minNumber = int.MaxValue;
    foreach (int number in nums)
    {
        if (number == x)
        {
            Console.WriteLine("true");
            return;
        }
        if (number < minNumber)
        {
            minNumber = number;
        }
    }
    Console.WriteLine(minNumber);
}