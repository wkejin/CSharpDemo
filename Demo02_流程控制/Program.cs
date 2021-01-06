using System;

namespace Demo02_流程控制
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("请输入一个整数：");
            // int intNum = Convert.ToInt32(Console.ReadLine());
            // if(intNum > 0)
            // {
            //     Console.WriteLine($"你输入了{intNum}，是一个正数。");
            // }
            // else if(intNum < 0)
            // {
            //     Console.WriteLine($"你输入了{intNum}, 是一个负数。");
            // }
            // else
            // {
            //     Console.WriteLine("你输入了0。");
            // }

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
