using System.Text;

namespace Builder
{
    internal class HtmlElement
    {
        internal string Name, Text;
        internal List<HtmlElement> Elements = new();
        private const int INDENT_SIZE = 2;

        public HtmlElement()
        {

        }

        public HtmlElement(string name, string text)
        {
            Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
            Text = text ?? throw new ArgumentNullException(paramName: nameof(text));
        }

        private string ToStringImp(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', INDENT_SIZE * indent);
            sb.Append($"{i}<{Name}>\n");

            if (!string.IsNullOrWhiteSpace(Text))
            {
                sb.Append(new string(' ', INDENT_SIZE * (indent + 1)));
                sb.Append(Text);
                sb.Append("\n");
            }

            foreach (var element in Elements)
            {
                sb.Append(element.ToStringImp(indent + 1));
            }

            sb.Append($"{i}</{Name}>\n");
            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringImp(0);
        }

    }
}
