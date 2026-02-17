using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class PersonDirector
    {
        //take interface if we change the type of the builder it doesn't matter
        public Person MakeDefaultPerson(IPersonBuilder builder)
        {
            return builder.SetAddress("None")
                          .SetHeight(0)
                          .SetWidth(0)
                          .SetName("None")
                          .Build();
        }
    }
}