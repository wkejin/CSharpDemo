using System;

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
        }

        private static void OutputArr(params int[] nums)
        {
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}
