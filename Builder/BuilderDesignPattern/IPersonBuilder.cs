using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public interface IPersonBuilder
    {
        //We Will Use Fluent Interface => bnraga3 el Object nafso 
        //3shan na3mel chaining
        public IPersonBuilder SetName(string name);
        public IPersonBuilder SetAddress(string address);
        public IPersonBuilder SetHeight(float height);
        public IPersonBuilder SetWidth(float Width);
        public IPersonBuilder Reset();
        public Person Build();
    }
}