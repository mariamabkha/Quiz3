using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IShape
{

    class Prism : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Prism()
        {
        }

        public Prism(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return 2*(Length*Width+Length*Height+Width*Height);
        }

        public double CalculatePerimeter()
        {
            throw new NotSupportedException(" ");
        }
    }
}
