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

            //Act
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

            //Act
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

            //Act
            string actual = Triangle.AnalyzeTriangle(firstside,secondside,thirdside);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidIsoscelesTriangle_Input7and6and7_OutputValidIsocelesTriangle()
        {
            //Firstside is equalto thirdside
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

        public void ValidScaleneTriangle_Input4and5and6_OutputValidScaleneTriangle()
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
        public void ValidScaleneTriangle_Input3and4and5_OutputValidScaleneTriangle()
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
        public void ValidScaleneTriangle_Input5and6and7_OutputValidScaleneTriangle()
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
        public void ValidScaleneTriangle_Input6and7and8_OutputValidScaleneTriangle()
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
        public void ValidScaleneTriangle_Input8and9and10_OutputValidScaleneTriangle()
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
        public void ValidZeroLengthTriangle_Input0and5and9_OutputValidZeroLengthTriangle()
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
        public void ValidZeroLengthTriangle_Input0and9and0_OutputValidZeroLengthTriangle()
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
        public void ValidZeroLengthTriangle_Input8and0and9_OutputValidZeroLengthTriangle()
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
        public void InvalidTriangle_Input6and2and3_OutputInvalidTriangle()
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
        public void InvalidTriangle_Input2and6and3_OutputInvalidTriangle()
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
        public void InvalidTriangle_Input3and3and6_OutputInvalidTriangle()
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
