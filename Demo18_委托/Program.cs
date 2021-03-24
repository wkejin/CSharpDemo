using System;
using System.Collections.Generic;

namespace Demo18_委托
{
    public delegate int Max(int[] nums);
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 2, 7, 4, 10, 8 };
            //Max m = new Max(GetMax);
            Max m = GetMax;
            int max = m(numbers);
            Console.WriteLine(max);

            Calc calc = new Calc();
            Action act = calc.Report;
            act();
            act.Invoke();
            Func<double, double, double> f1 = calc.Add;
            Func<double, double, double> f2 = calc.Mul;
            Console.WriteLine(f1(1, 2));
            Console.WriteLine(f2(1.3d, 2.2d));
        }

        static int GetMax(int[] nums)
        {
            int max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            return max;
        }
    }

    class Calc
    {
        public void Report()
        {
            Console.WriteLine("I have 4 methods.");
        }

        public double Add(double a, double b) => a + b;
        public double Sub(double a, double b) => a - b;
        public double Mul(double a, double b) => a * b;
        public double Div(double a, double b)
        {
            double res = b != 0 ? a / b : 0;
            return res;
        }
    }
}
