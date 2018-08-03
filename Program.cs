using System;
using DesignPatterns.Builder;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            DemoBuilder();
        }

        static void DemoBuilder()
        {
            var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age","int");

            Console.WriteLine(cb);
        }
    }
}
