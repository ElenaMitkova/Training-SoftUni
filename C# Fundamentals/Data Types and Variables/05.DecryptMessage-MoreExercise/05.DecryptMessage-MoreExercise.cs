int key = int.Parse(Console.ReadLine());
int numberOfLines = int.Parse(Console.ReadLine());
string output = "";
while (numberOfLines > 0)
{
    char line = char.Parse(Console.ReadLine());
    output += (char)(line + key);
    numberOfLines--;
}
Console.WriteLine(output);