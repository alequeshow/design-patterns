using System;
using System.Collections.Generic;

namespace DesignPatterns.Builder
{
    public class CodeBuilder
    {
        private Code parent;
        private const int ident = 2;

        public CodeBuilder(string name)
        {
            parent = new Code(){Name = name, Type = "class"};            
        }

        public CodeBuilder AddField(string name, string type)
        {
            parent.Fields.Add(new Code(){ Name = name, Type = type});

            return this;
        }

        public override string ToString()
        {
            return parent.ToString();
        }
    }
}