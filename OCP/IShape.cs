using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCP
{
    public interface IShape
    {

        public double CalcArea();
        // {
        // switch (Type)
        // {
        //     case ShapeType.Circle: return Math.PI * Math.Pow(Radius, 2);
        //     case ShapeType.Rectangle:
        //         return Length * Width;
        //     default:
        //         throw new InvalidOperationException("Unsupported shape type");
        // }
        // }
    }
}