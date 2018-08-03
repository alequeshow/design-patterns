using System;
using DesignPatterns.Builder;
using DesignPatterns.Factory;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            //DemoBuilder();
            DemoFactory();
        }

        static void DemoBuilder()
        {
            var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age","int");

            Console.WriteLine(cb);
        }

        static void DemoFactory()
        {
            var pf = new PersonFactory();

            var person1 = pf.CreatePerson("Alex");
            var person2 = pf.CreatePerson("Crayson");

            Console.WriteLine(person1);
            Console.WriteLine(person2);
        }
    }
}
