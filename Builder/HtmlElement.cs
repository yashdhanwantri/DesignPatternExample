using System.Text;

namespace DesignPatternExample.Builder
{
    public class HtmlElement
    {
        public string Name, Text;
        public List<HtmlElement> Elements = new List<HtmlElement>();
        public const int indentSize = 2;

        public HtmlElement(string name, string text)
        {
            Name = name;
            Text = text;
        }

        public HtmlElement() { }

        private string ToStringImpl(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', indentSize * indent);
            sb.Append($"{i}<{Name}>");

            if (!string.IsNullOrWhiteSpace(Text))
            {
                sb.Append(new string(' ', indentSize * (indent+1)));
                sb.AppendLine(Text);
            }

            foreach(var e in Elements)
            {
                sb.Append(e.ToStringImpl(indent + 1));
            }

            sb.AppendLine($"{i}</{Name}>");
            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringImpl(0);
        }
    }
}
