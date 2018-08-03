using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class Code
    {
        public string  Name { get; set; }
        public string Type {get; set;}        
        public List<Code> Fields { get; set; }
        private const int indentSize = 2;       

        public Code()
        {
            Fields = new List<Code>();
        }

        public override string ToString()
        {
            return ToStringIdent(0);
        }

        private string ToStringIdent(int level)
        {
            var i = new string(' ', indentSize * level);
            var sb = new StringBuilder();
            var collon = this.Type.ToLower() != "class" ? ";" : "";
            
            sb.AppendLine($"{i}public {this.Type} {this.Name}{collon}");

            if(this.Type.ToLower() == "class")
            {
                sb.AppendLine($"{i}{{");

                foreach(var item in this.Fields)
                    sb.Append(item.ToStringIdent(level + 1));                
                
                sb.AppendLine($"{i}}}");
            }

            return sb.ToString();
        }
    }
}