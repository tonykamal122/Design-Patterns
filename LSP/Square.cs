using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSP
{
    public class Square : IShape
    {
        public int Side { get; set; }
        public double CalcArea() => Side * Side;
    }
}