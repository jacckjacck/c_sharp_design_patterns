namespace Builder
{
    internal class HtmlBuilder
    {
        private readonly string rootName;
        HtmlElement root = new();

        internal HtmlBuilder(string rootName)
        {
            this.rootName = rootName;
            root.Name = rootName;
        }

        internal HtmlBuilder AddChild(string childName, string childText)
        {
            var element = new HtmlElement(childName, childText);
            root.Elements.Add(element);
            return this;
        }

        public override string ToString()
        {
            return root.ToString();
        }

        internal void Clear()
        {
            root = new HtmlElement { Name = rootName };
        }
    }
}
