using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IShape
{
    class Triangle : IShape
    {
        public double Base { get; set; }
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Height { get; set; }

        public Triangle()
        {
        }

        public Triangle(double @base, double side1, double side2, double height)
        {
            Base = @base;
            Side1 = side1;
            Side2 = side2;
            Height = height;
        }

        public double CalculateArea()
        {
            return (Base * Height) / 2;
        }

        public double CalculatePerimeter()
        {
            return Side1 + Side2 + Base;
        }

    }
}
