using Microsoft.VisualStudio.TestTools.UnitTesting;
using NodFinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodFinder.Tests
{
    [TestClass()]
    public class GCDTests
    {
        [DataTestMethod()]
        [DataRow(21, 252, 105)]
        [DataRow(21, 105, 252)]
        [DataRow(21, 147, 105)]
        [DataRow(21, 42, 105)]
        [DataRow(21, 42, 63)]
        [DataRow(21, 42, 21)]
        [DataRow(21, 21, 21)]
        [DataRow(21, 0, 21)]
        [DataRow(21, 21, 0)]
        [DataRow(21, -252, 105)]
        [DataRow(21, -252, -105)]
        [DataRow(1,7,13)]
        [DataRow(1,13,7)]
        public void EuclidTest(int expectedGCD, int num1, int num2)
        {
            int realGCD = GCD.Euclid(num1, num2);
            Assert.AreEqual(realGCD, expectedGCD);
        }
    }
}