using System;

namespace Demo05_乘法表
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write($"{i}*{j}={i*j}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
