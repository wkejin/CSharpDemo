using System;

namespace Demo14_接口
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public  void CHLSS()
        {
            Console.WriteLine("我是人类，我可以吃喝拉撒睡。");
        }
    }
}
