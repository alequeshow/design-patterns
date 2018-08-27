using System;
using DesignPatterns.Builder;
using DesignPatterns.Factory;
using DesignPatterns.Prototype;
using DesignPatterns.Singleton;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            //DemoBuilder();
            //DemoFactory();
            //DemoPrototype();
            DemoSingleton();
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

        static void DemoPrototype()
        {
            var ln1 = new Line();
            ln1.Start = new Point(){X = 12, Y = 6};
            ln1.End = new Point(){X = 60, Y = 22};

            var ln2 = ln1.DeepCopy();

            ln2.Start.X = 6;
            ln2.Start.Y = 12;

            ln2.End.X = 22;
            ln2.End.Y = 60;

            Console.WriteLine(ln1);
            Console.WriteLine(ln2);
        }

        static void DemoSingleton()
        {
            //Test1 - Singleton
            var obj1 = Singleton.Singleton.Instance;            

            var isSingleton =  SingletonTester.IsSingleton(() => obj1);

            Console.WriteLine($"Test 1 is singleton: { isSingleton }");
        }
    }
}
