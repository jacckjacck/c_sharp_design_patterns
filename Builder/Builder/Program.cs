// See https://aka.ms/new-console-template for more information
using Builder;
using System.Text;
using static System.Console;

var Hello = "hello";
var sb = new StringBuilder();
sb.Append("<p>");
sb.Append(Hello);
sb.Append("</p>");
WriteLine(sb);

var words = new[] { "hello", "world" };
sb.Clear();
sb.Append("<ul>");

foreach (var word in words)
{
    sb.AppendFormat("<li>{0}</li>", word);
}

sb.Append("</ul>");
WriteLine(sb);

var builder = new HtmlBuilder("ul");
builder.AddChild("li", "hello");
builder.AddChild("li", "world");
WriteLine(builder.ToString());

var builder2 = new HtmlBuilder("ul");
builder2
    .AddChild("li", "hello")
    .AddChild("li", "world");
WriteLine(builder.ToString());