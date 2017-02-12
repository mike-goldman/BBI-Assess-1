using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolygonSolution;
namespace PolygonSoutionTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TriangleTestValid()
        {
            Triangle myTriangle = new Triangle();
            // Assign
            myTriangle.Sides[0] = 3;
            myTriangle.Sides[1] = 4;
            myTriangle.Sides[2] = 5;
            var expected = ShapeType.Scalene;
            // Act 
            var actual = myTriangle.GetTriangleType();

            // Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TriangleTestInvalidSide1()
        {
            Triangle myTriangle = new Triangle();
            // Assign
           
            myTriangle.Sides[1] = 4;
            myTriangle.Sides[2] = 5;
            var expected = ShapeType.Error;
            // Act 
            var actual = myTriangle.GetTriangleType();

            // Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TriangleTestInvalidSide2()
        {
            Triangle myTriangle = new Triangle();
            // Assign

            myTriangle.Sides[0] = 4;
            myTriangle.Sides[2] = 5;
            var expected = ShapeType.Error;
            // Act 
            var actual = myTriangle.GetTriangleType();

            // Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TriangleTestInvalidSide3()
        {
            Triangle myTriangle = new Triangle();
            // Assign

            myTriangle.Sides[0] = 4;
            myTriangle.Sides[1] = 5;
            var expected = ShapeType.Error;
            // Act 
            var actual = myTriangle.GetTriangleType();

            // Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TriangleTestScalene()
        {
            Triangle myTriangle = new Triangle();
            // Assign
            myTriangle.Sides[0] = 3;
            myTriangle.Sides[1] = 4;
            myTriangle.Sides[2] = 5;
            var expected = ShapeType.Scalene;
            // Act 
            var actual = myTriangle.GetTriangleType();

            // Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TriangleTestIsosceles()
        {
            Triangle myTriangle = new Triangle();
            // Assign
            myTriangle.Sides[0] = 3;
            myTriangle.Sides[1] = 3;
            myTriangle.Sides[2] = 5;
            var expected = ShapeType.Isosceles;
            // Act 
            var actual = myTriangle.GetTriangleType();

            // Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TriangleTestEquilateral()
        {
            Triangle myTriangle = new Triangle();
            // Assign
            myTriangle.Sides[0] = 3;
            myTriangle.Sides[1] = 3;
            myTriangle.Sides[2] = 3;
            var expected = ShapeType.Equilateral;
            // Act 
            var actual = myTriangle.GetTriangleType();

            // Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
