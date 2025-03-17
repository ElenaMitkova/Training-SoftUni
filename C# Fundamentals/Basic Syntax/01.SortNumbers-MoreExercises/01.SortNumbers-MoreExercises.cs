int firstNumber = int.Parse(Console.ReadLine());
int secondfNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());
int[] array = new int[3];
array[0] = firstNumber;
array[1] = secondfNumber;
array[2] = thirdNumber;
int temp = 0;
for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array.Length - 1; j++)
    {
        if (array[j] < array[j + 1])
        {
            temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
}
for (int i = 0;i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}