using System;

namespace Demo08_匿名类型和var
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建了一个匿名类型对象
            var p = new {
                Name = "张三",
                Age = 19,
                Gender = "男"
            };

            Console.WriteLine($"我叫{p.Name},性别{p.Gender},今年{p.Age}岁。");

            //使用var关键字来定义已知类型的变量，编译器会推断此变量的类型
            var a = 6;
            var b = 3.14;
            var input = Console.ReadLine();
            Console.WriteLine($"{a}\t{b}\t{input}");
        }
    }
}
