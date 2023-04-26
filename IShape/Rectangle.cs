using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IShape
{
    class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle()
        {
        }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }


        public double CalculateArea()
        {
            return Length * Width;
        }

        
    }
}
