int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
bool isGreater = false;
int[] output = new int [numbers.Length];
int counter = 0;
for (int i = 0; i < numbers.Length; i++)
{
    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (numbers[i] > numbers[j])
        {
            isGreater = true;
        }
        else
        {
            isGreater = false;
            break;
        }
    }
    if (isGreater) 
    { 
        output[counter] = numbers[i];
        counter++;
        isGreater = false;
    }
}
output[counter] = numbers[numbers.Length - 1];
for (int i = 0; i < counter; i++)
{
    Console.Write($"{output[i]} ");
}
Console.WriteLine(output[counter]);