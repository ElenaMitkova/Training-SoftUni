int counter = int.Parse(Console.ReadLine());
if (counter == 1 )
{
    Console.WriteLine(1);
    return;
}
Console.WriteLine(1);
long[] array = { 1, 1 };
Console.WriteLine(1 + " " + 1);
for (int i = 2; i < counter; i++)
{
    Console.Write(1);
    long[] temp = new long[i + 1];
    temp[0] = 1;
    for (int j = 1; j < array.Length; j++)
    {
        Console.Write(" " + (array[j] + array[j - 1]));
        temp[j] = array[j] + array[j - 1];
    }
    Console.WriteLine(" " + 1);
    temp[temp.Length - 1] = 1;
    array = temp;
}