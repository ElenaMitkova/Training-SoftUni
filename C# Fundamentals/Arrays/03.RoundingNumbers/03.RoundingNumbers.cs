double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
int[] output = new int[numbers.Length];
for (int i = 0; i < numbers.Length; i++)
{
    output[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
    Console.WriteLine($"{numbers[i]} => {output[i]}");
}