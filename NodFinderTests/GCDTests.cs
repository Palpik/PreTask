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
        /// <summary>
        /// Тестирование правильности нахождения НОД двух чисел методом Euqlid
        /// </summary>
        /// <param name="expectedGCD">Ожидаемый НОД</param>
        /// <param name="num1">данные</param>
        /// <param name="num2">данные</param>
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
        public void Euclid_TwoNumbers_ReturnsGCD(int expectedGCD, int num1, int num2)
        {
            int realGCD = GCD.Euclid(num1, num2, out _);
            Assert.AreEqual(expectedGCD, realGCD);
        }

        /// <summary>
        /// Тестирование нахождения НОД трех чисел методом Euqlid
        /// </summary>
        /// <param name="expectedGCD">Ожидаемый НОД</param>
        /// <param name="num1">данные</param>
        /// <param name="num2">данные</param>
        /// <param name="num3">данные</param>
        [DataTestMethod()]
        [DataRow(21, 252, 252, 105)]
        [DataRow(252, 252, 252, 252)]
        [DataRow(21, -252, 105, 147)]
        [DataRow(7, 252, 105, 7)]
        [DataRow(21, 252, 105, 0)]
        [DataRow(15, 0, 0, 15)]
        public void Euclid_ThreeNumbers_ReturnsGCD(int expectedGCD, int num1, int num2, int num3)
        {
            int realGCD = GCD.Euclid(num1, num2, num3);
            Assert.AreEqual(expectedGCD, realGCD);
        }

        /// <summary>
        /// Тестирование нахождения НОД четырех чисел методом Euqlid
        /// </summary>
        /// <param name="expectedGCD">Ожидаемый НОД</param>
        /// <param name="num1">данные</param>
        /// <param name="num2">данные</param>
        /// <param name="num3">данные</param>
        /// <param name="num4">данные</param>
        [DataTestMethod()]
        [DataRow(21, 252, 147, 105, 63)]
        [DataRow(252, 252, 252, 252, 252)]
        [DataRow(21, -252, 105, 147, -63)]
        [DataRow(1, 252, 105, 7, 3)]
        [DataRow(21, 0, 105, 147, 0)]
        [DataRow(15, 0, 0, 0, 15)]
        public void Euclid_FourNumbers_ReturnsGCD(int expectedGCD, int num1, int num2, int num3, int num4)
        {
            int realGCD = GCD.Euclid(num1, num2, num3,num4);
            Assert.AreEqual(expectedGCD, realGCD);
        }

        /// <summary>
        /// Тестирование нахождения НОД пяти чисел методом Euqlid
        /// </summary>
        /// <param name="expectedGCD">Ожидаемый НОД</param>
        /// <param name="num1">данные</param>
        /// <param name="num2">данные</param>
        /// <param name="num3">данные</param>
        /// <param name="num4">данные</param>
        /// <param name="num5">данные</param>
        [DataTestMethod()]
        [DataRow(21, 252, 147, 105, 63, 42)]
        [DataRow(252, 252, 252, 252, 252, 252)]
        [DataRow(1,1,323,12,23,132)]
        [DataRow(15,0,0,0,0,15)]
        public void Euclid_FiveNumbers_ReturnsGCD(int expectedGCD, int num1, int num2, int num3, int num4, int num5)
        {
            int realGCD = GCD.Euclid(num1, num2, num3, num4, num5);
            Assert.AreEqual(expectedGCD, realGCD);
        }

        /// <summary>
        /// Тестирование правильности нахождения НОД двух чисел методом Stein
        /// </summary>
        /// <param name="expectedGCD">Ожидаемый НОД</param>
        /// <param name="num1">данные</param>
        /// <param name="num2">данные</param>
        [DataTestMethod()]
        [DataRow(21, 147, 105)]
        [DataRow(21, 252, 105)]
        [DataRow(21, 105, 252)]
        [DataRow(21, 42, 105)]
        [DataRow(21, 42, 63)]
        [DataRow(21, 42, 21)]
        [DataRow(21, 21, 21)]
        [DataRow(21, 0, 21)]
        [DataRow(21, 21, 0)]
        [DataRow(21, -252, 105)]
        [DataRow(21, -252, -105)]
        [DataRow(1, 7, 13)]
        [DataRow(1, 13, 7)]
        public void Stein_TwoNumbers_ReturnsGCD(int expectedGCD, int num1, int num2)
        {
            int realGCD = GCD.Stein(num1, num2, out _);
            Assert.AreEqual(expectedGCD, realGCD);
        }

        /// <summary>
        /// НОД не может быть вычичлен если все числа равны 0
        /// </summary>
        [TestMethod()]
        public void Euclid_TwoNumbers_Exception()
        {
            try
            {
                GCD.Euclid(0, 0, out _);
                Assert.Fail("Нет ошибки о нулях в НОД");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Все числа равны нулю", ex.Message,"Возникло непредвиденное исключение");
            }
        }

        /// <summary>
        /// НОД не может быть вычичлен если все числа равны 0
        /// </summary>
        [TestMethod()]
        public void Stein_TwoNumbers_Exception()
        {
            try
            {
                GCD.Stein(0, 0, out _);
                Assert.Fail("Нет ошибки о нулях в НОД");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Все числа равны нулю", ex.Message, "Возникло непредвиденное исключение");
            }
        }
    }
}