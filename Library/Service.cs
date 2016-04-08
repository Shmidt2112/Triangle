using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Shapes;

namespace Library
{
    public class Service
    {
        public static double GetTriangleSqr(double side1, double side2, double side3)
        {
            var triangle = new Triangle(side1, side2, side3);
            return triangle.Sqr();
        }
    }
}
