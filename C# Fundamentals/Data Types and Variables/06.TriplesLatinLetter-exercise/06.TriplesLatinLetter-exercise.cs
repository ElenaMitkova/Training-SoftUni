byte counter = byte.Parse(Console.ReadLine());
int number = 'a' + counter;
for (char i = 'a'; i < number; i++)
{
    for (char j = 'a'; j < number; j++)
    {
        for (char k = 'a'; k < number; k++)
        {
            Console.WriteLine($"{i}{j}{k}");
        }
    }
}