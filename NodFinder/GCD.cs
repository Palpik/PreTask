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
    }
}
