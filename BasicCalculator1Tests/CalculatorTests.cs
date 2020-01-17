using Microsoft.VisualStudio.TestTools.UnitTesting;
using Basic_Calculator1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Calculator1.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        private readonly int a = 50;
        private readonly int b = 10;       
        private readonly Calculator calculator = new Calculator();
        
        [TestMethod()]
        public void AddTest()
        {
            Assert.AreEqual(60, calculator.Add(a, b));

        }

        [TestMethod()]
        public void DivideTest()
        {      
                
           Assert.AreEqual(5, calculator.Divide(a, b));
        }

        [TestMethod()]
        public void SubtractTest()
        {
            Assert.AreEqual(40, calculator.Subtracts(a, b));
        }

        [TestMethod()]
        public void SquareTest()
        {
             
            Assert.AreEqual(2500, calculator.Square(a));
        }

        
    }

        /*[TestMethod()]

        public void AddIntDoubleTest()
        {
            Calculator calculator = new Calculator();
            int a = 1;
            double b = 2.02;
            double c = calculator.Add(a, b);

            Assert.AreEqual(3.02, c);
            Assert.AreEqual(3.02, calculator.result);

        }*/
    
}