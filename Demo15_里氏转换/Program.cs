using System;

namespace Demo15_里氏转换
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Perosn[] p = new Perosn[10];
            for (int i = 0; i < p.Length; i++)
            {
                int randomNum = r.Next(1, 5);
                switch (randomNum)
                {
                    case 1:
                        p[i] = new Student();
                        break;
                    case 2:
                        p[i] = new Teacher();
                        break;
                    case 3:
                        p[i] = new Girl();
                        break;
                    case 4:
                        p[i] = new Boy();
                        break;
                    default: break;
                }
            }

            foreach(var item in p)
            {
                if(item is Student)
                {
                    ((Student)item).Say();
                }
                else if(item is Teacher)
                {
                    ((Teacher)item).Say();
                }
                else if(item is Girl)
                {
                    ((Girl)item).Say();
                }
                else
                {
                    ((Boy)item).Say();
                }
            }
        }
    }

    public class Perosn
    {
        public void Say()
        {
            Console.WriteLine("我是人类");
        }
    }

    public class Teacher : Perosn
    {
        public new void Say()
        {
            Console.WriteLine("我是老师");
        }
    }

    public class Student : Perosn
    {
        public new void Say()
        {
            Console.WriteLine("我是学生");
        }
    }

    public class Girl : Perosn
    {
        public new void Say()
        {
            Console.WriteLine("我是美女");
        }
    }

    public class Boy : Perosn
    {
        public new void Say()
        {
            Console.WriteLine("我是帅哥");
        }
    }
}
