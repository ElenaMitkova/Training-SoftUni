long counter = long.Parse(Console.ReadLine());
if (counter == 0)
{
    Console.WriteLine();
    return;
}
if (counter == 1)
{
    Console.Write(1);
    return;
}
Console.Write(1);
Console.Write(" " + 1 + " " + 2 + " ");
string output = "";
long[] array = { 1, 1, 2};
for (int i = 4; i <= counter; i++)
{
    output += $"{array[0] + array[1] + array[2]} ";
    long num = array[0] + array[1] + array[2];
    array[0] = array[1];
    array[1] = array[2];
    array[2] = num;
}
Console.WriteLine(output.Trim(' '));