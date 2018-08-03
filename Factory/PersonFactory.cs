using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class PersonFactory
    {
        private int count = 0;
        public PersonFactory()
        { }

        public Person CreatePerson(string name)
        {
            return new Person(){Name = name, Id = count++};
        }
    }
}