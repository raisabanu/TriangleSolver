using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;

namespace TriangleTest
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]

        public void ValidEquilateralTriangle_Input5and5and5_OutputValidEquilateralTriangle()
        {
            //Arrange

            int firstside = 5;
            int secondside = 5;
            int thirdside = 5;

            string expected = "The triangle is valid and is an EQUILATERAL";

            //Actual
            string actual = Triangle.AnalyzeTriangle(firstside,secondside,thirdside);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void ValidIsoscelesTriangle_Input4and5and5_OutputValidIsoscelesTriangle()
        {
            //secondside is equal to thirdside
            //Arrange
            int firstside = 4;
            int secondside = 5;
            int thirdside = 5;


            string expected = "The triangle is valid and is an ISOSCELES";

            //Actual
            string actual = Triangle.AnalyzeTriangle(firstside,secondside,thirdside);

            //Assert

            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void ValidIsoscelesTriangle_Input4and4and5_OutputValidIsoscelesTriangle()
        {
            //Firstside is equal to secondside
            //Arrange
            int firstside = 4;
            int secondside = 4;
            int thirdside = 5;

            string expected = "The triangle is valid and is an ISOSCELES";

            //Actual
            string actual = Triangle.AnalyzeTriangle(firstside,secondside,thirdside);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidIsoscelesTriangle_Input7and6and7_OutputValidIsocelesTriangle()
        {
            //Firstside is equalto thirdside
            //Arrange

            int firstside = 7;
            int secondside = 6;
            int thirdside = 7;

            string expected = "The triangle is valid and is an ISOSCELES";

            //Actual
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);

        }

        [Test]
        public void ValidZeroLengthTriangle_Input0and0and0_OutputValidZeroLengthTriangle()
        {

           //ARRANGE
            int firstside = 0;
            int secondside = 0;
            int thirdside = 0;

            string expected = "At least one side of your triangle has a zero length and is thus invalid";

          //Actual
          string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);

          //Assert
           Assert.AreEqual(expected, actual);
        }

    }
}
