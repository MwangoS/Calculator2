﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class DivisionTests
    {
        private readonly int a = 10;
        private readonly int b = 2;
        private readonly int c = 0;
        /*private readonly double c = 50.5;
        private readonly double d = 2.5;*/

        [TestMethod()]
        public void QuotientIntDivideZeroTest()
        {
            Assert.ThrowsException<DivideByZeroException>(() => Division.Divide(a, c));
        }

        [TestMethod()]
        public void DivideIntTest()
        {
            Assert.AreEqual(0, Division.Divide(b, a));
        }
        
       /* [TestMethod()]
        public void DivideTest()
        {
            Assert.AreEqual(5, Division.Divide(a, b));
        }

        [TestMethod()]
        public void DivideDoubleTest()
        {
            Assert.AreEqual(20.2, Division.Divide(c, d));
        }*/
    }
}