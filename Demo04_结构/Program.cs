using System;

namespace Demo04_结构
{
    /// <summary>
    /// 声明了名为Student的结构类型
    /// </summary>
    public struct Student
    {
        public int _id;
        public string _name;
        public int _age;

        public void Say()
        {
            Console.WriteLine($"我是学生，名叫{_name},我今年{_age}岁。");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //使用结构类型
            Student stuZS;
            stuZS._id = 1;
            stuZS._name = "张三";
            stuZS._age = 20;

            stuZS.Say();
        }
    }
}
