using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecurrsionAssignment
{
    internal class Exercise
    {
        public static int multiply(int a, int b)
        {
            if (b == 1)
            {
                return a;
            }
            return a + multiply(a, b - 1);
        }
        public static int sumOfDigits(int n)
        {
            if (n / 10 < 1)
            {
                return n;
            }
            return n % 10 + sumOfDigits(n / 10);
        }
        public static int power(int a, int b)
        {
            if (b == 1)
            {
                return a;
            }
            return a * power(a, b - 1);
        }
        public static string reversed(int num)
        {
            if (num / 10 < 1)
            {

                return num.ToString();
            }
            return (num % 10).ToString() + reversed(num / 10);
        }


    }
}
