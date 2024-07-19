using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library1;
using System;

namespace ArithmeticMath
{
    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void Add_Test()
        {
            Program at = new Program();

            int? resultActual = at.Add(3, 5);
            Assert.AreEqual(resultActual, 8, "Adding 3 and 5 should result in 8.");

            int? resultNullInput = at.Add(null, 5);
            Assert.IsNull(resultNullInput, "Adding null should return null result.");

            int? resultBothNull = at.Add(null, null);
            Assert.IsNull(resultBothNull, "Adding two null values should return null result.");
        }

        [TestMethod]
        public void Subtract_Test()
        {
            Program at = new Program();

            int? resultActual = at.Subtract(10, 5);
            Assert.AreEqual(resultActual, 5, "Subtracting 5 from 10 should result in 5.");

            int? resultNullInput = at.Subtract(null, 5);
            Assert.IsNull(resultNullInput, "Subtracting from null should return null result.");

            int? resultBothNull = at.Subtract(null, null);
            Assert.IsNull(resultBothNull, "Subtracting two null values should return null result.");
        }

        [TestMethod]
        public void Multiply_Test()
        {
            Program at = new Program();

            int? resultActual = at.Multiply(3, 5);
            Assert.AreEqual(resultActual, 15, "Multiplying 3 and 5 should result in 15.");

            int? resultNullInput = at.Multiply(null, 5);
            Assert.IsNull(resultNullInput, "Multiplying with null should return null result.");

            int? resultBothNull = at.Multiply(null, null);
            Assert.IsNull(resultBothNull, "Multiplying two null values should return null result.");
        }

        [TestMethod]
        public void Square_Test()
        {
            Program at = new Program();

            int? resultActual = at.Square(3);
            Assert.AreEqual(resultActual, 9, "Square of 3 should be 9.");

            int? resultNullInput = at.Square(null);
            Assert.IsNull(resultNullInput, "Square of null should return null result.");
        }
    }
}

