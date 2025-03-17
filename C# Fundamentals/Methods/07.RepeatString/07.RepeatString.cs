string input = Console.ReadLine();
int counter = int.Parse(Console.ReadLine());
Console.WriteLine(GetString(input, counter));
static string GetString(string input, int counter)
{
    string output = "";
    for (int i = 0; i < counter; i++)
    {
        output += input;
    }
    return output;
}