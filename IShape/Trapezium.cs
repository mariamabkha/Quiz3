using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IShape
{
        public class Trapezium : IShape
        {
            private double topWidth;
            private double bottomWidth;
            private double height;
            private double side1;
            private double side2;

            public Trapezium(double topWidth, double bottomWidth, double height, double side1, double side2)
            {
                this.topWidth = topWidth;
                this.bottomWidth = bottomWidth;
                this.height = height;
                this.side1 = side1;
                this.side2 = side2;
            }

            public double CalculateArea()
            {
                return (topWidth + bottomWidth) * height / 2;
            }

            public double CalculatePerimeter()
            {

                return topWidth + bottomWidth + side1 + side2;
            }


        }
}
