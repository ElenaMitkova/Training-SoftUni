List<Article> list = new List<Article>();
int counter = int.Parse(Console.ReadLine());
for (int i = 0; i < counter; i++)
{
    string[] articles = Console.ReadLine().Split(", ");
    Article article = new Article(articles[0], articles[1], articles[2]);
    list.Add(article);
}
foreach (Article article in list)
{
    Console.WriteLine(article);
}
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
    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}