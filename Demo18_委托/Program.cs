using System;

namespace Demo18_委托
{
    delegate int Max(int[] nums);
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 2, 7, 4, 10, 8 };
            Max m = new Max(GetMax);
            int max = m(numbers);
            Console.WriteLine(max);
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
}
