using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class PersonBuilder : IPersonBuilder
    {
        private Person person;
        public PersonBuilder()
        {
            Reset();
        }
        public Person Build()
        {
            Person result = person;
            Reset();
            return result; // Just Return the object
        }

        public IPersonBuilder Reset() //Reset the object
        {
            person = new Person();
            return this; //For fluent interface design pattern
        }

        public IPersonBuilder SetAddress(string address)
        {
            person.Address = address;
            return this;
        }

        public IPersonBuilder SetHeight(float height)
        {
            person.Height = height;
            return this;
        }

        public IPersonBuilder SetName(string name)
        {
            person.Name = name;
            return this;
        }

        public IPersonBuilder SetWidth(float width)
        {
            person.Width = width;
            return this;
        }
    }
}