using System;

namespace Demo11_递归
{
    class Program
    {
        static void Main(string[] args)
        {
            //计算4!
            Console.WriteLine(Fact(4));
        }

        /// <summary>
        /// 递归计算一个整数的阶乘
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static int Fact(int num)
        {
            if(num <= 1)
            {
                return 1;
            }
            return num * Fact(num - 1);
        }
    }
}
