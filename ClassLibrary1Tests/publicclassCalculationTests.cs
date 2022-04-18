using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class publicclassCalculationTests
    {
        [TestMethod()]
        public void GetDiscountTest()
        {
            int rez = 11;
            Calculation calculation = new Calculation();
            int fak = calculation.GetDiscount(5, 700);
            Assert.AreEqual(rez, fak);
        }
        [TestMethod()]
        public void GetDiscountTest1()
        {
            int rez = 6;
            Calculation calculation = new Calculation();
            int fak = calculation.GetDiscount(4, 950);
            Assert.AreEqual(rez, fak);
        }
        public void GetDiscountTest2()
        {
            int rez = 5;
            Calculation calculation = new Calculation();
            int fak = calculation.GetDiscount(4, 950);
            Assert.AreEqual(rez, fak);
        }
    }
}