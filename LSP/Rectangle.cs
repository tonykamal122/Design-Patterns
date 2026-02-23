using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSP
{
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double CalcArea() => Width * Height;
    }
}