using System;

namespace Demo09_元组
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用元组可以将不同类型变量一起声明
            (string name, int age, string gender) = ("张三", 30, "男");
            Console.WriteLine($"我叫{name},性别{gender},今年{age}岁。");

            var(n, a, g) = ("李四", 20, "女");
            Console.WriteLine($"我叫{n},性别{g},年龄{a}");

            var personInfo = (Name: "王五", Age: 21, Gender: "男");
            Console.WriteLine($"我叫{personInfo.Name}，今年{personInfo.Age}岁，性别{personInfo.Gender}");
        }
    }
}
