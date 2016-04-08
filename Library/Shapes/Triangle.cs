using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Abstract;

namespace Library.Shapes
{
    class Triangle : Shape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public double SemiPerimetr => (Side1 + Side2 + Side3)/2;

        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public override double Sqr()
        {
            if (Side1 <= 0 || Side2 <= 0 || Side3 <= 0)
                return 0;
            return Math.Sqrt(SemiPerimetr*(SemiPerimetr - Side1)*(SemiPerimetr - Side2)*(SemiPerimetr - Side2));
        }
    }
}
