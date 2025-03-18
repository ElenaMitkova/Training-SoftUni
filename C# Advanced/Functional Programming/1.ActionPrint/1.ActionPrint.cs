string[] names = Console.ReadLine().Split();
Action<string> printingNames = x => Console.WriteLine(x);
foreach (string name in names)
{
    printingNames(name);
}