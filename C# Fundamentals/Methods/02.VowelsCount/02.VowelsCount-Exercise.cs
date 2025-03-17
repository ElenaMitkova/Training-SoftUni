string input = Console.ReadLine();
Console.WriteLine(VowsCount(input));
static int VowsCount(string input)
{
    int count = 0;  
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] is 'a' or 'e' or 'y' or 'u' or 'i' or 'o' or 'A' or 'E' or 'Y' or 'U' or 'I' or 'O')
        {
            count++;
        }
    }
    return count;
}