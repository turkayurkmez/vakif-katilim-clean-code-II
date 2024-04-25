using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovsSubstution
{
    public class Geometry
    {
        public ICalcutableArea GetRectangle(int unit1, int? unit2=null)
        {
            if (unit2.HasValue)
            {
                return new Rectangle { Width = unit1, Height = unit2.Value };
            }


            return new Square() {  EdgeLength=unit1};
        }
    }

    public interface ICalcutableArea
    {
        double GetArea();
    }

    public class Rectangle : ICalcutableArea
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public double GetArea() => Width * Height;
    }

    public class Square : ICalcutableArea//: Rectangle
    {
        public int EdgeLength { get; set; }
        public double GetArea() => Math.Pow(EdgeLength, 2);
    }

}
