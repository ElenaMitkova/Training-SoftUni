int counter = int.Parse(Console.ReadLine());
List<Song> list = new List<Song>();
for (int i = 0; i < counter; i++)
{
    string[] input = Console.ReadLine().Split('_').ToArray();
    Song song = new Song();
    song.TypeList = input[0];
    song.Name = input[1];
    song.Time = input[2];
    list.Add(song);
}
string outputLine = Console.ReadLine();
if (outputLine == "all")
{
    foreach (var item in list)
    {
        Console.WriteLine(item.Name);
    }
    return;
}
foreach (var item in list)
{
    if (item.TypeList == outputLine)
    {
        Console.WriteLine(item.Name);
    }
}
class Song
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }
}