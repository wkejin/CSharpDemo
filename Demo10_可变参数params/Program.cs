﻿using System;

namespace Demo10_可变参数params
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            OutputArr(a);
            int[] nums = {1, 2, 3, 4, 5};
            OutputArr(nums);
            OutputArr(12,34,56);
        }

        /// <summary>
        /// 方法的参数不一定只有一个，params修饰的参数必须是最后一个
        /// </summary>
        /// <param name="nums"></param>
        private static void OutputArr(params int[] nums)
        {
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}
