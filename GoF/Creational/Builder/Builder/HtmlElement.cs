using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class HtmlElement
    {
        private const int _indentSize = 2;
        public string Name { get; set; }
        public string Text { get; set; }
        public List<HtmlElement> Elements = new List<HtmlElement>();

        public HtmlElement()
        {
            
        }
        public HtmlElement(string name, string text)
        {
            Name = name;
            Text = text;

        }
        private string ToStringImpl(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', _indentSize * indent);
            sb.AppendLine($"{i}<{Name}>");

            if (!string.IsNullOrWhiteSpace(Text))
            {
                sb.Append(new string(' ',_indentSize * (indent+1)));
                sb.AppendLine(Text);
            }

            foreach (var element in Elements) 
            {
                sb.Append(element.ToStringImpl(indent+1));
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
