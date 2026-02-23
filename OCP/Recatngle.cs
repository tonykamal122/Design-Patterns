using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCP
{
    public class Recatngle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double CalcArea() => Length * Width;
    }
}