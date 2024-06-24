using static DesignPatternExample.Builder.HtmlElement;

namespace DesignPatternExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "Hello")
                .AddChild("li", "World");
            var htmlElement = builder.ToString();
            Console.WriteLine(htmlElement);
        }
    }
}
