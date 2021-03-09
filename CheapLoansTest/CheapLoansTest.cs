using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CheapLoansProject
{
    /// <summary>
    /// Created 3/5/2021 by Lucas Chapman.
    /// Unit test class for testing the Calc() method.
    /// </summary>
    [TestClass]
    public class CheapLoansTest
    {
        /// <summary>
        /// Tests the Calc() method using the AreEqual() method
        /// </summary>
        [TestMethod]
        public void TestCalcAreEqual()
        {
            string monPayments = CheapLoans.Calc(8.0, 4, 2000.00);
            Assert.AreEqual("603.84", monPayments, "The actual amount is $" + monPayments + ", not $603.84");
        }

        /// <summary>
        /// Tests the Calc() method using the AreNotEqual() method
        /// </summary>
        [TestMethod]
        public void TestCalcAreNotEqual()
        {
            string monPayments = CheapLoans.Calc(8.0, 4, 2000.00);
            Assert.AreNotEqual("500.00", monPayments, "The actual amount is $500.00");
        }

        /// <summary>
        /// Tests the Calc() method using the IsTrue() method
        /// </summary>
        [TestMethod]
        public void TestCalcIsTrue()
        {
            string monPayments = CheapLoans.Calc(0.1, 1, 0.01);
            Assert.IsTrue(monPayments.Equals("0.01"), "The actual amount is $" + monPayments + ", not $0.01");
        }

        /// <summary>
        /// Tests the Calc() method using the IsFalse() method
        /// </summary>
        [TestMethod]
        public void TestCalcIsFalse()
        {
            string monPayments = CheapLoans.Calc(0.1, 1, 0.01);
            Assert.IsFalse(!monPayments.Equals("0.01"), "The actual amount is $0.01");
        }

        /// <summary>
        /// Tests the Calc() method using the Fail() method
        /// </summary>
        [TestMethod]
        public void TestCalcFail()
        {
            string monPayments1 = CheapLoans.Calc(99.9, 25, 99999.99);
            string monPayments2 = CheapLoans.Calc(99.9, 1, 99999.99);

            try
            {
                Assert.AreEqual("99,899.99", monPayments1);
                Assert.AreEqual("199,899.98", monPayments2);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}
