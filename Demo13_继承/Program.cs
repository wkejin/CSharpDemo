using System;

namespace Demo13_继承
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Student()
            {
                Id = 1,
                Name = "张三",
                ClassName = "3(2)班"
            };
            Person p2 = new Teacher()
            {
                Id = 2,
                Name = "李四",
                Salary = 5000
            };
            p1.SayHi();
            p2.SayHi();
        }
    }
}
