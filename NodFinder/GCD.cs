using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodFinder
{
    public class GCD
    {
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
                return num2;
            }
        }
        public static int Euclid(int num1, int num2, int num3)
        {
            if (num1 == 0 && num2 == 0)
                return Euclid(0, num3, out _);
            else
                return Euclid(Euclid(num1, num2, out _), num3, out _);
        }
        public static int Euclid(int num1, int num2, int num3, int num4)
        {
            if (num1 == 0 && num2 == 0 && num3 == 0)
                return Euclid(0, num4, out _);
            else
                return Euclid(Euclid(num1, num2, num3), num4, out _);
        }
        public static int Euclid(int num1, int num2, int num3, int num4, int num5)
        {
            if (num1 == 0 && num2 == 0 && num3 == 0 && num4 == 0)
                return Euclid(0, num5, out _);
            else
                return Euclid(Euclid(num1, num2, num3, num4), num5, out _);
        }
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
                return num1;
            }
            if (num1 == 0)
            {
                watch.Stop();
                time = watch.ElapsedMilliseconds;
                return num2;
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
    }
}
