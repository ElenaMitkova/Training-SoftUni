using System.Text;

string title = Console.ReadLine();
StringBuilder builder = new StringBuilder();
builder.AppendLine("<h1>");
builder.AppendLine($"   {title}");
builder.AppendLine("</h1>");
string titleContent = Console.ReadLine();
builder.AppendLine("<article>");
builder.AppendLine($"   {titleContent}");
builder.AppendLine("</article>");
string comments;
while ((comments = Console.ReadLine()) != "end of comments")
{
    builder.AppendLine("<div>");
    builder.AppendLine($"   {comments}");
    builder.AppendLine("</div>");
}
Console.WriteLine(builder.ToString());