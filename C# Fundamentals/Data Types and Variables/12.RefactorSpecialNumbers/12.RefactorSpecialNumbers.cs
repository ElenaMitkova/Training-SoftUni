int countNumber = int.Parse(Console.ReadLine());
bool isEqual = false;
for (int i = 1; i <= countNumber; i++)
{
    int sum = 0;
    int number = i;
    while (number > 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    isEqual = (sum == 5) || (sum == 7) || (sum == 11);
    Console.WriteLine("{0} -> {1}", i, isEqual);
}