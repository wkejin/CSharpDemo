using System;

namespace Demo06_方法
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 4D;
            double n2 = 2D;
            Console.WriteLine(Div(n1, n2));
        }
        
        private static double Add(double a, double b)
        {
            return a + b;
        }

        private static double Sub(double a, double b)
        {
            return a - b;
        }

        private static double Mul(double a, double b)
        {
            return a * b;
        }

        private static double Div(double a, double b)
        {
            double res = 0;
            if(b != 0)
            {
                res = a /b;
            }
            else
            {
                Console.WriteLine("被除数不能为0。");
            }
            return res;
        }
    }
}
