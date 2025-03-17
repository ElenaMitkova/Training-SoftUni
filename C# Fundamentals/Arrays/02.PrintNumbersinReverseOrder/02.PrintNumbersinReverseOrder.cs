int numberCount = int.Parse(Console.ReadLine());
int[] numbers = new int[numberCount];
for (int i = 0; i < numberCount; i++) numbers[i] = int.Parse(Console.ReadLine());
for (int i = numbers.Length - 1; i >= 0; i--) Console.Write($"{numbers[i]} ");