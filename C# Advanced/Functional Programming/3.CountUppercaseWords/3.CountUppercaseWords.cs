Func<string, bool> uppingChar = x => x[0] == x.ToUpper()[0];
string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Where(uppingChar).ToArray();
Console.WriteLine(string.Join('\n', words));