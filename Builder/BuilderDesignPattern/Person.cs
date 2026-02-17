using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class Person
    {
        public string Name { get; set; } = default!;
        public string Address { get; set; } = default!;
        public float Height { get; set; } = default!;
        public float Width { get; set; } = default!;
        public Person()
        {

        }
        public Person(string name, string address, float height, float width)
        {
            Name = name;
            Address = address;
            Height = height;
            Width = width;
        }
        //dah 8alat leah b2a? 3shan fe paremeters kteer yab2a nasta3mel el builder Design Pattern

        public void Show()
        {
            Console.WriteLine(@$"$Name = {Name} ,
                                Address = {Address},
                                Height{Height},
                                Width = {Width}");
        }

    }
}