string[] stringsArray = Console.ReadLine().Split();
for (int i = 0; i < stringsArray.Length / 2; i++)
{
    string temp = stringsArray[i];
    stringsArray[i] = stringsArray[stringsArray.Length - 1 - i];
    stringsArray[stringsArray.Length - 1 - i] = temp;
}
Console.WriteLine(string.Join(" ",stringsArray));