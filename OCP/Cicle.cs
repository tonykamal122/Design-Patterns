using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCP
{
    public class Cicle : IShape
    {
        public double Radius { get; set; }
        public double CalcArea() => Math.Pow(Radius, 2) * Math.PI;
    }
}