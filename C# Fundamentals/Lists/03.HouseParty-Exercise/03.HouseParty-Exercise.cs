int counter = int.Parse(Console.ReadLine());
List<string> names = new List<string>();
while (counter > 0)
{
    string[] command = Console.ReadLine().Split();
    string name = command[0];
    switch (command[2])
    {
        case "going!" when !names.Contains(name):
            names.Add(name);
            break;
        case "going!" when names.Contains(name):
            Console.WriteLine($"{name} is already in the list!");
            break;
        case "not" when names.Contains(name):
            names.Remove(name);
            break;
        case "not" when !names.Contains(name):
            Console.WriteLine($"{name} is not in the list!");
            break;
    }
    counter--;
}
Console.WriteLine(string.Join("\n", names));