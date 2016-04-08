using System;
using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void Test_Triangle_Sqr_on_positive_values()
        {
            var side1 = 2;
            var side2 = 2;
            var side3 = 2;

            var result = Service.GetTriangleSqr(side1, side2, side3);

            // var sqr =  Math.Sqrt(SemiPerimetr*(SemiPerimetr - Side1)*(SemiPerimetr - Side2)*(SemiPerimetr - Side2));
            var semiPerimetr = (side1 + side2 + side3)/2;
            var sqr = Math.Sqrt(semiPerimetr*(semiPerimetr - side1)*(semiPerimetr - side2)*(semiPerimetr - side3));

            Assert.AreEqual(sqr, result);
        }

        [TestMethod]
        public void Test_Triangle_Sqr_on_negative_values()
        {
            var side1 = -2;
            var side2 = -2;
            var side3 = -2;

            var result = Service.GetTriangleSqr(side1, side2, side3);

            Assert.AreEqual(0, result);
        }
    }
}
