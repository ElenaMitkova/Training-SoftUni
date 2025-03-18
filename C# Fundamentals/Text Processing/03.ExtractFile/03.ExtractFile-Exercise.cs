string text = Console.ReadLine();
int indexDot = text.LastIndexOf('.');
string extension = text.Substring(indexDot + 1);
int index = text.LastIndexOf('\\');
string file = text.Substring(index + 1);
string fileName = file.Substring(0, file.Length - extension.Length - 1);
Console.WriteLine($"File name: {fileName}");
Console.WriteLine($"File extension: {extension}");