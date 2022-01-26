using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodFinder
{
    public class GCD
    {
        public static int Euclid(int num1,int num2)
        {
            num1 = Math.Abs(num1);
            num2 = Math.Abs(num2);
            if (num1 == 0 && num2 == 0)
                throw new Exception("Все числа равны нулю");
            if (num1 == num2)
                return num1;
            while (num1 != 0 && num2 !=0)
                if (num1 > num2)
                    num1 = num1 % num2;
                else if (num1 < num2)
                    num2 = num2 % num1;
            if (num1 == 0)
                return num2;
            else
                return num1;
        }
        public static int Euclid(int num1, int num2, int num3)
        {
            if (num1 == 0 && num2 == 0)
                return Euclid(0, num3);
            else
                return Euclid(Euclid(num1, num2), num3);
        }
        public static int Euclid(int num1, int num2, int num3, int num4)
        {
            if (num1 == 0 && num2 == 0 && num3 == 0)
                return Euclid(0, num4);
            else
                return Euclid(Euclid(num1, num2, num3), num4);
        }
        public static int Euclid(int num1, int num2, int num3, int num4, int num5)
        {
            if (num1 == 0 && num2 == 0 && num3 == 0 && num4 == 0)
                return Euclid(0, num5);
            else
                return Euclid(Euclid(num1, num2, num3, num4), num5);
        }
    }
}
