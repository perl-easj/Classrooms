using System;
using System.Collections.Generic;
using System.Linq;
using ClassroomC;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestClassroomC
{
    [TestClass]
    public class MediCareTest
    {
        #region Setup for generalised test
        private Dictionary<double, double> _expenses;

        public MediCareTest()
        {
            _expenses = new Dictionary<double, double>();
            _expenses.Add(0, 0);
            _expenses.Add(1, 1);
            _expenses.Add(500, 500);
            _expenses.Add(950, 950);
            _expenses.Add(1200, 1075);
            _expenses.Add(1565, 1257.5);
            _expenses.Add(2500, 1491.25);
            _expenses.Add(3390, 1713.75);
            _expenses.Add(6000, 2105.25);
            _expenses.Add(18331, 3954.9);
            _expenses.Add(30000, 3954.9);
        }


        private void RunTestCase(int caseNo)
        {
            // Arrange
            MediCare mCare = new MediCare();
            double expense = _expenses.Keys.ToList()[caseNo];
            double expectedResult = _expenses.Values.ToList()[caseNo];

            // Act
            double actualResult = mCare.SubsidisedExpense(expense);

            // Assert
            Assert.AreEqual(expectedResult, actualResult, 0.01, $"Fail {expense:F} kr.");
        }
        #endregion

        #region Generalised tests
        [TestMethod]
        public void RunTestCase_00()
        {
            RunTestCase(0);
        }

        [TestMethod]
        public void RunTestCase_01()
        {
            RunTestCase(1);
        }

        [TestMethod]
        public void RunTestCase_02()
        {
            RunTestCase(2);
        }

        [TestMethod]
        public void RunTestCase_03()
        {
            RunTestCase(3);
        }

        [TestMethod]
        public void RunTestCase_04()
        {
            RunTestCase(4);
        }

        [TestMethod]
        public void RunTestCase_05()
        {
            RunTestCase(5);
        }

        [TestMethod]
        public void RunTestCase_06()
        {
            RunTestCase(6);
        }

        [TestMethod]
        public void RunTestCase_07()
        {
            RunTestCase(7);
        }

        [TestMethod]
        public void RunTestCase_08()
        {
            RunTestCase(8);
        }

        [TestMethod]
        public void RunTestCase_09()
        {
            RunTestCase(9);
        }

        [TestMethod]
        public void RunTestCase_10()
        {
            RunTestCase(10);
        }
        #endregion

        //[TestMethod]
        //public void SubsidisedExpense_0kr_0kr()
        //{
        //    // Arrange
        //    MediCare mCare = new MediCare();
        //    double expense = 0.0;
        //    double expectedResult = 0.0;

        //    // Act
        //    double actualResult = mCare.SubsidisedExpense(expense);

        //    // Assert
        //    Assert.AreEqual(expectedResult, actualResult, 0.01, "Fail 0 kr.");
        //}

        //[TestMethod]
        //public void SubsidisedExpense_1kr_1kr()
        //{
        //    // Arrange
        //    MediCare mCare = new MediCare();
        //    double expense = 1.0;
        //    double expectedResult = 1.0;

        //    // Act
        //    double actualResult = mCare.SubsidisedExpense(expense);

        //    // Assert
        //    Assert.AreEqual(expectedResult, actualResult, 0.01, "Fail 1 kr.");
        //}

        //[TestMethod]
        //public void SubsidisedExpense_950kr_950kr()
        //{
        //    // Arrange
        //    MediCare mCare = new MediCare();
        //    double expense = 950.0;
        //    double expectedResult = 950.0;

        //    // Act
        //    double actualResult = mCare.SubsidisedExpense(expense);

        //    // Assert
        //    Assert.AreEqual(expectedResult, actualResult, 0.01, "Fail 1 kr.");
        //}

        //[TestMethod]
        //public void SubsidisedExpense_1000kr_975kr()
        //{
        //    // Arrange
        //    MediCare mCare = new MediCare();
        //    double expense = 1000.0;
        //    double expectedResult = 975.0;

        //    // Act
        //    double actualResult = mCare.SubsidisedExpense(expense);

        //    // Assert
        //    Assert.AreEqual(expectedResult, actualResult, 0.01, "Fail 1000 kr.");
        //}

        //[TestMethod]
        //public void SubsidisedExpense_1500kr_1225kr()
        //{
        //    // Arrange
        //    MediCare mCare = new MediCare();
        //    double expense = 1500.0;
        //    double expectedResult = 1225.0;

        //    // Act
        //    double actualResult = mCare.SubsidisedExpense(expense);

        //    // Assert
        //    Assert.AreEqual(expectedResult, actualResult, 0.01, "Fail 1500 kr.");
        //}

        //[TestMethod]
        //public void SubsidisedExpense_2000kr_1366_25kr()
        //{
        //    // Arrange
        //    MediCare mCare = new MediCare();
        //    double expense = 2000.0;
        //    double expectedResult = 1366.25;

        //    // Act
        //    double actualResult = mCare.SubsidisedExpense(expense);

        //    // Assert
        //    Assert.AreEqual(expectedResult, actualResult, 0.01, "Fail 1500 kr.");
        //}

        //[TestMethod]
        //public void SubsidisedExpense_Negative_Exception()
        //{
        //    // Arrange
        //    MediCare mCare = new MediCare();
        //    double expense = -1.0;

        //    // Act & Assert
        //    Assert.ThrowsException<ArgumentException>(() => { mCare.SubsidisedExpense(expense); });
        //}
    }
}
