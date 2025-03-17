string[] stringsArray1 = Console.ReadLine().Split(' ');
string[] stringsArray2 = Console.ReadLine().Split(' ');
string[] output = new string[stringsArray1.Length];
int count = 0;
for (int i = 0; i < stringsArray2.Length; i++)
{
    for (int j = 0; j < stringsArray1.Length; j++)
    {
        if (stringsArray1[j] == stringsArray2[i])
        {
            output[count] = stringsArray1[j];
            count++;
        }
    }
}
for (int i = 0; i < count; i++) Console.Write($"{output[i]} ");
Console.Write(output[output.Length - 1]);