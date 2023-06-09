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

        public void AnalyzeTriangle_input5and5and5_outputValidEquilateralTriangle()
        {
            //Arrange

            int firstside = 5;
            int secondside = 5;
            int thirdside = 5;

            string expected = "The triangle is valid and is an EQUILATERAL";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstside,secondside,thirdside);

            //Assert
            Assert.AreEqual(expected, actual);
        }       

        [Test]

        public void AnalyzeTriangle_input4and5and5_outputValidIsoscelesTriangle()
        {
            //Arrange
            int firstside = 4;
            int secondside = 5;
            int thirdside = 5;


            string expected = "The triangle is valid and is an ISOSCELES";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstside,secondside,thirdside);

            //Assert

            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void AnalyzeTriangle_input4and4and5_outputValidIsoscelesTriangle()
        {
            //Arrange
            int firstside = 4;
            int secondside = 4;
            int thirdside = 5;

            string expected = "The triangle is valid and is an ISOSCELES";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstside,secondside,thirdside);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_input7and6and7_outputValidIsocelesTriangle()
        {
            //Arrange
            ;
            int firstside = 7;
            int secondside = 6;
            int thirdside = 7;

            string expected = "The triangle is valid and is an ISOSCELES";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);


            //Assert
            Assert.AreEqual(expected, actual);

        }
        [Test]

        public void AnalyzeTriangle_input4and5and6_outputValidScaleneTriangle()
        {
            //Arrange
            int firstside = 4;
            int secondside = 5;
            int thirdside = 6;

            string expected = "The triangle is valid and is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void AnalyzeTriangle_input3and4and5_outputValidScaleneTriangle()
        {
            //Arrange
            int firstside = 3;
            int secondside = 4;
            int thirdside = 5;

            string expected = "The triangle is valid and is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void AnalyzeTriangle_input5and6and7_outputValidScaleneTriangle()
        {
            //Arrange
            int firstside = 5;
            int secondside = 6;
            int thirdside = 7;

            string expected = "The triangle is valid and is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AnalyzeTriangle_input6and7and8_outputValidScaleneTriangle()
        {
            //Arrange
            int firstside = 6;
            int secondside = 7;
            int thirdside = 8;

            string expected = "The triangle is valid and is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_input8and9and10_outputValidScaleneTriangle()
        {
            //Arrange
            int firstside = 8;
            int secondside = 9;
            int thirdside = 10;

            string expected = "The triangle is valid and is a SCALENE";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void AnalyzeTriangle_input0and5and9_outputValidZeroLengthTriangle()
        {
            //Arrange
            int firstside = 0;
            int secondside = 5;
            int thirdside = 9;

            string expected = "At least one side of your triangle has a zero length and is thus invalid";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);

            //Assert
            Assert.AreEqual(expected, actual);

        }


        [Test]
        public void AnalyzeTriangle_input0and9and0_outputValidZeroLengthTriangle()
        {

            //Arrange
            int firstside = 0;
            int secondside = 9;
            int thirdside = 0;

            string expected = "At least one side of your triangle has a zero length and is thus invalid";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_input8and0and9_outputValidZeroLengthTriangle()
        {
            //Arrange
            int firstside = 8;
            int secondside= 0;
            int thirdside = 9;

            string expected = "At least one side of your triangle has a zero length and is thus invalid";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void AnalyzeTriangle_input6and2and3_outputInvalidTriangle()
        {
            //Arrange
            int firstside = 6;
            int secondside = 2;
            int thirdside = 3;

            string expected = "A triangle cannot be formed with those numbers";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);

            //Assert    
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AnalyzeTriangle_input2and6and3_outputInvalidTriangle()
        {
            //Arrange
            int firstside = 2;
            int secondside = 6;
            int thirdside = 3;

            string expected = "A triangle cannot be formed with those numbers";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);

            //Assert    
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AnalyzeTriangle_input3and3and6_outputInvalidTriangle()
        {
            //Arrange
            int firstside = 3;
            int secondside = 3;
            int thirdside = 6;

            string expected = "A triangle cannot be formed with those numbers";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstside, secondside, thirdside);

            //Assert    
            Assert.AreEqual(expected, actual);
        }


    }
}
