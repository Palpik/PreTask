using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodFinder
{
    /// <summary>
    /// Класс GCD содержит функции для расчета НОД по алгоритмам Евклида и Штэйна (Стэйна).
    /// </summary>
    public class GCD
    {
        /// <summary>
        /// Метод Euclid реализует алгоритм Евклида по вычислению НОД двух целых чиселв
        /// По крайней мере одно из чисел должно быть не равно 0
        /// </summary>
        /// <param name="num1">Целое число</param>
        /// <param name="num2">Целое число</param>
        /// <param name="time">Время вычисления НОД</param>
        /// <returns>Возвращает НОД двух чисел</returns>
        public static int Euclid(int num1,int num2, out long time)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            if (num1 == 0 && num2 == 0)
                throw new Exception("Все числа равны нулю");

            num1 = Math.Abs(num1);
            num2 = Math.Abs(num2);
            if (num1 == num2)
            {
                watch.Stop();
                time = watch.ElapsedMilliseconds;
                return num1;
            }
            while (num1 != 0 && num2 !=0)
                if (num1 > num2)
                    num1 = num1 % num2;
                else if (num1 < num2)
                    num2 = num2 % num1;
            if (num1 == 0)
            {
                watch.Stop();
                time = watch.ElapsedMilliseconds;
                return num2;
            }
            else
            {
                watch.Stop();
                time = watch.ElapsedMilliseconds;
                return num1;
            }
        }
        /// <summary>
        /// Перегрузка метода Euqlid, которая вычисляет НОД трех чисел
        /// Одно из чисел должно быть неравно нулю
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <returns>Возвращает НОД трех чисел</returns>
        public static int Euclid(int num1, int num2, int num3)
        {
            if (num1 == 0 && num2 == 0)
                return Euclid(0, num3, out _);
            else
                return Euclid(Euclid(num1, num2, out _), num3, out _);
        }
        /// <summary>
        /// Перегрузка метода Euqlid, которая вычисляет НОД четрыех чисел
        /// Одно из чисел должно быть неравно нулю
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <param name="num4"></param>
        /// <returns>Возвращает НОД четырех чисел</returns>
        public static int Euclid(int num1, int num2, int num3, int num4)
        {
            if (num1 == 0 && num2 == 0 && num3 == 0)
                return Euclid(0, num4, out _);
            else
                return Euclid(Euclid(num1, num2, num3), num4, out _);
        }
        /// <summary>
        /// Перегрузка метода Euqlid, которая вычисляет НОД пяти чисел
        /// Одно из чисел должно быть неравно нулю
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <param name="num4"></param>
        /// <param name="num5"></param>
        /// <returns>Возвращает НОД пяти чисел</returns>
        public static int Euclid(int num1, int num2, int num3, int num4, int num5)
        {
            if (num1 == 0 && num2 == 0 && num3 == 0 && num4 == 0)
                return Euclid(0, num5, out _);
            else
                return Euclid(Euclid(num1, num2, num3, num4), num5, out _);
        }

        /// <summary>
        /// Метод Stein реализует алгоритм Стейна по вычислению НОД двух целых чисел
        /// Одно из чисел должно быть неравно нулю
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="time"></param>
        /// <returns>Возвращает НОД двух чисел</returns>
        public static int Stein(int num1, int num2, out long time)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            if (num1 == 0 && num2 == 0)
                throw new Exception("Все числа равны нулю");

            num1 = Math.Abs(num1);
            num2 = Math.Abs(num2);
            if (num1 == num2 || num1 == 0)
            {
                watch.Stop();
                time = watch.ElapsedMilliseconds;
                return num2;
            }
            if (num2 == 0)
            {
                watch.Stop();
                time = watch.ElapsedMilliseconds;
                return num1;
            }
            int k = 0;
            while (num1 % 2 == 0 && num2 % 2 == 0)
            {
                num1 >>= 1;
                num2 >>= 1;
                k += 1;
            }
            while (num1 != num2)
            {
                while (num1 % 2 != 1)
                    num1 = num1 >> 1;
                while (num2 % 2 != 1)
                    num2 = num2 >> 1;
                if (num1 > num2)
                    num1 = (num1 - num2) >> 1;
                else if (num2 > num1)
                    num2 = (num2 - num1) >> 1;
            }
            watch.Stop();
            time = watch.ElapsedMilliseconds;
            return num1*(int)Math.Pow(2,k);
        }

        /// <summary>
        /// Метод GetDataAboutTime реализует подготовку данных о времени вычисления НОД двух чисел методами Euclid и Stein
        /// При одинаковых данных
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="timeEuclid">Выходной параметр, Время вычисления НОД Алгоритмом Евклида</param>
        /// <param name="timeStein">Выходной параметр, Время вычисления НОД Алгоритмом Стэйна</param>
        public static void GetDataAboutTime(int num1, int num2, out long timeEuclid, out long timeStein)
        {
            _ = Euclid(num1,num2, out timeEuclid);
            _ = Stein(num1, num2, out timeStein);
        }
    }
}
