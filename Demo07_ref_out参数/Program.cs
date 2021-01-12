using System;

namespace Demo07_ref_out参数
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 3;
            Swap1(a, b);    //无法交换
            Console.WriteLine($"a={a}, b={b}");
            Swap2(ref a, ref b);    //可以交换
            Console.WriteLine($"a={a}, b={b}");
        }

        /// <summary>
        /// 交换两个数，由于这里的参数是值类型，仅仅是传递过来的副本，所以无法交换
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private static void Swap1(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// 交换两个数，使用ref关键字修饰可以使值类型变成引用类型，可以交换成功
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private static void Swap2(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
