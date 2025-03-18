string[] strings = Console.ReadLine().Split();
string concatenatedString = "";
for (int i = 0; i < strings.Length; i++)
{
    for (int j = 0; j < strings[i].Length; j++)
    {
        concatenatedString += strings[i];
    }
}
Console.WriteLine(concatenatedString);