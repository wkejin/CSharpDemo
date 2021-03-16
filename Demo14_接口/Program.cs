using System;

namespace Demo14_接口
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Id = 1;
            p.Name = "Tom";
            p.Say();
            p.Eat();
            p.Work();
        }
    }

    public class Person : IAction
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public  void Say()
        {
            Console.WriteLine("Hello!");
        }

        public void Eat()
        {
            Console.WriteLine("I'm eating foods.");
        }

        public void Work()
        {
            Console.WriteLine("I'm working.");
        }

    }

    //接口声明，继承接口的类必须实现其中所有定义的方法

    public interface IAction
    {
        void Say();
        void Eat();
        void Work();
    }
}
