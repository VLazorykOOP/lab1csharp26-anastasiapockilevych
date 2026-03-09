using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    [TestClass]
    public class TaskTests
    {
        [TestMethod] 
        public void Task1_Positive()
        {
            Assert.AreEqual(5.0, Tasks.GetRadius(Math.PI * 25), 0.001);
        }

        [TestMethod]
        public void Task1_Negative()
        {
            Assert.AreEqual(10.0, Tasks.GetRadius(Math.PI * 25), 0.001);
        }

        [TestMethod]
        public void Task2_Positive()
        {
            Assert.AreEqual(1, Tasks.CompareDigits(425));
        }

        [TestMethod]
        public void Task2_Negative()
        {
            Assert.AreEqual(0, Tasks.CompareDigits(123));
        }

        [TestMethod]
        public void Task3_Positive()
        {
            Assert.AreEqual("Так", Tasks.CheckPoint(-10, -5));
        }

        [TestMethod]
        public void Task3_Negative()
        {
            Assert.AreEqual("Так", Tasks.CheckPoint(10, 10));
        }

        [TestMethod]
        public void Task4_Positive()
        {
            Assert.AreEqual("Дракона", Tasks.GetChineseZodiac(2024));
        }

        [TestMethod]
        public void Task4_Negative()
        {
            Assert.AreEqual("Щура", Tasks.GetChineseZodiac(2024));
        }

        [TestMethod]
        public void Task5_Positive()
        {
            Assert.AreEqual(4.0, Tasks.SquareOfDifference(5, 3));
        }

        [TestMethod]
        public void Task5_Negative()
        {
            Assert.AreEqual(25.0, Tasks.SquareOfDifference(5, 3));
        }

        [TestMethod]
        public void Task6_Positive()
        {
            double result = Tasks.CalculateExpression(1, 2);
            Assert.AreEqual(0.1071, result, 0.0001);
        }

        [TestMethod]
        public void Task6_Negative()
        {
            Assert.AreEqual(0.0, Tasks.CalculateExpression(1, 2));
        }

        [TestMethod]
        public void Task1_Exception_Check()
        {
            try
            {
                Tasks.GetRadius(-5);
            }
            catch (ArgumentException)
            {
                return;
            }
            Assert.Fail();
        }
    }
}
