using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddNumbersTest()
        {
            Calculator simpleCalc = new Calculator();
            var result = simpleCalc.AddNumbers(1, 2);
            Assert.IsTrue(result == 3);
        }
    }
}