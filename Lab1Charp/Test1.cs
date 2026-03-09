using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    [TestClass]
    public class TaskTests
    {
        // --- ЗАВДАННЯ 1: Радіус ---
        [TestMethod]
        public void Task1_ShouldPass() // Пройде
        {
            Assert.AreEqual(5.0, Tasks.GetRadius(Math.PI * 25), 0.001);
        }

        [TestMethod]
        public void Task1_ShouldFail_WrongExpected() // ПРОВАЛИТЬСЯ (очікуємо 10 замість 5)
        {
            Assert.AreEqual(10.0, Tasks.GetRadius(Math.PI * 25), 0.001);
        }


        // --- ЗАВДАННЯ 2: Цифри ---
        [TestMethod]
        public void Task2_ShouldPass() // Пройде (4 > 2)
        {
            Assert.AreEqual(1, Tasks.CompareDigits(425));
        }

        [TestMethod]
        public void Task2_ShouldFail_LogicError() // ПРОВАЛИТЬСЯ (кажемо, що цифри рівні, а вони ні)
        {
            Assert.AreEqual(0, Tasks.CompareDigits(123));
        }


        // --- ЗАВДАННЯ 3: Точка в області ---
        [TestMethod]
        public void Task3_ShouldPass() // Пройде
        {
            Assert.AreEqual("Так", Tasks.CheckPoint(-10, -5));
        }

        [TestMethod]
        public void Task3_ShouldFail_WrongZone() // ПРОВАЛИТЬСЯ (точка (10,10) поза областю)
        {
            Assert.AreEqual("Так", Tasks.CheckPoint(10, 10));
        }


        // --- ЗАВДАННЯ 4: Календар ---
        [TestMethod]
        public void Task4_ShouldPass() // Пройде
        {
            Assert.AreEqual("Дракона", Tasks.GetChineseZodiac(2024));
        }

        [TestMethod]
        public void Task4_ShouldFail_WrongAnimal() // ПРОВАЛИТЬСЯ
        {
            Assert.AreEqual("Щура", Tasks.GetChineseZodiac(2024));
        }


        // --- ЗАВДАННЯ 5: Квадрат різниці ---
        [TestMethod]
        public void Task5_ShouldPass() // Пройде (5-3)^2 = 4
        {
            Assert.AreEqual(4.0, Tasks.SquareOfDifference(5, 3));
        }

        [TestMethod]
        public void Task5_ShouldFail_WrongMath() // ПРОВАЛИТЬСЯ
        {
            Assert.AreEqual(25.0, Tasks.SquareOfDifference(5, 3));
        }


        // --- ЗАВДАННЯ 6: Вираз ---
        [TestMethod]
        public void Task6_ShouldPass() // Пройде
        {
            double result = Tasks.CalculateExpression(1, 2);
            Assert.AreEqual(0.1071, result, 0.0001);
        }

        [TestMethod]
        public void Task6_ShouldFail_ZeroExpected() // ПРОВАЛИТЬСЯ
        {
            Assert.AreEqual(0.0, Tasks.CalculateExpression(1, 2));
        }

        // --- ДОДАТКОВО: Тест на помилку (справжній негативний тест) ---
        [TestMethod]
        public void Task1_NegativeArea_CheckException() // Має пройти, бо ми очікуємо помилку
        {
            try
            {
                Tasks.GetRadius(-5);
                Assert.Fail("Помилка не виникла!");
            }
            catch (ArgumentException)
            {
                // Все ок, ми чекали саме на ArgumentException
            }
        }
    }
}