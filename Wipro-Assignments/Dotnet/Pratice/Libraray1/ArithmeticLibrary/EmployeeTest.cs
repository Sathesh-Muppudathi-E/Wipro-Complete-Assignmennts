using System;
using NUnit.Framework;

namespace ArithmeticLibrary
{
    [TestFixture]
    public class ArithmeticOperationsTests
    {
        private ArithmeticOperations _arithmetic;

        [SetUp]
        public void Setup()
        {
            
            _arithmetic = new ArithmeticOperations();
        }

        [TearDown]
        public void Teardown()
        {
           
            _arithmetic = null;
        }

        [Test]
        public void Add_ShouldReturnSumOfTwoNumbers()
        {
           
            int a = 5;
            int b = 3;

            int result = _arithmetic.Add(a, b);

        
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void Subtract_ShouldReturnDifferenceOfTwoNumbers()
        {
           
            int a = 5;
            int b = 3;

           
            int result = _arithmetic.Subtract(a, b);

           
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Multiply_ShouldReturnProductOfTwoNumbers()
        {
            
            int a = 5;
            int b = 3;

          
            int result = _arithmetic.Multiply(a, b);

            
            Assert.That(result, Is.EqualTo(15));
        }

        [Test]
        public void Divide_ShouldReturnQuotientOfTwoNumbers()
        {
            
            int a = 6;
            int b = 3;

           
            double result = _arithmetic.Divide(a, b);

            
            Assert.That(result, Is.EqualTo(2.0));
        }

        [Test]
        public void Divide_ByZero_ShouldThrowDivideByZeroException()
        {
           
            int a = 6;
            int b = 0;

           
            Assert.Throws<DivideByZeroException>(() => _arithmetic.Divide(a, b));
        }
    }
}