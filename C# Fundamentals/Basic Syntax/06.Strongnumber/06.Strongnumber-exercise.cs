int number = int.Parse(Console.ReadLine());
int numberCopy = number;
int sum = 0;
while (numberCopy > 0)
{
    int factorial = numberCopy % 10;
    int sumFac = 1;
    for (int i = 1; i <= factorial; i++)
    {
        sumFac *= i;
    }
    sum += sumFac;
    numberCopy /= 10;
}
if (sum == number) Console.WriteLine("yes");
else Console.WriteLine("no");