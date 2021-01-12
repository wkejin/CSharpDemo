using System;

namespace Demo12_类与对象
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student(1, "张三", "3(2)");
            stu1.Say();
            Console.WriteLine($"我是{stu1.Name}, 我在{stu1.ClassName}班");
        }
    }

    public class Student
    {
        /// <summary>
        /// 此为Student类的默认构造方法
        /// </summary>
        public Student()
        {

        }
        
        /// <summary>
        /// Student类的构造方法，用于初始化Student对象
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="className"></param>
        public Student(int id, string name, string className)
        {
            this.Id = id;
            this.Name = name;
            this.ClassName = className;
        }

        //字段
        private int _id;
        private string _name;

        //属性
        public int Id
        {
            get{return _id;}
            set{_id = value;}
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        //自动属性
        public string ClassName { get; set; }

        /// <summary>
        /// Student类的成员方法
        /// </summary>
        public void Say()
        {
            Console.WriteLine($"My name is {this.Name}, I'm a student.");
        }    
    }
}
