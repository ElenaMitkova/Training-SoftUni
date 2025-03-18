string[] articles = Console.ReadLine().Split(", ").ToArray();
Article article = new Article(articles[0], articles[1], articles[2]);
int counter = int.Parse(Console.ReadLine());
for (int i = 0; i < counter; i++)
{
    string[] commands = Console.ReadLine().Split(':');
    commands[1] = commands[1].Trim(' ');
    switch (commands[0])
    {
        case "Edit":
            article.Edit(commands[1]);
            break;
        case "ChangeAuthor":
            article.ChangeAuthor(commands[1]);
            break;
        case "Rename":
            article.Rename(commands[1]);
            break;
    }
}
Console.WriteLine(article);
class Article
{
    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
    public void Edit(string newContent)
    {
        Content = newContent;
    }
    public void ChangeAuthor(string newAuthor)
    {
        Author = newAuthor;
    }
    public void Rename(string newTitle)
    {
        Title = newTitle;
    }
    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}