using System;

namespace Demo16_多态
{
    class Program
    {
        static void Main(string[] args)
        {
            //实现多态的手段：抽象类、虚方法、接口
            //如果父类需要实例化则用虚方法来实现多态，如果父类不需要实例化则用抽象类来实现多态
            
            //1.使用虚方法
            Chinese cn1 = new Chinese("张三");
            Chinese cn2 = new Chinese("李四");
            Japanese jp1 = new Japanese("苍井空");
            Japanese jp2 = new Japanese("三上悠亚");
            Person[] pers = { cn1, cn2, jp1, jp2 };
            foreach (var item in pers)
            {
                item.Say();
            }

            //2.使用抽象类实现
            Animal a1 = new Dog();
            Animal a2 = new Cat();
            a1.Bark();
            a2.Bark();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            this.Name = name;
        }

        public virtual void Say()
        {
            Console.WriteLine("我是人类");
        }
    }

    public class Chinese : Person
    {
        public Chinese(string name) : base(name) { }

        public override void Say()
        {
            Console.WriteLine($"我是中国人，我叫{this.Name}");
        }
    }

    public class Japanese : Person
    {
        public Japanese(string name) : base(name) { }

        public override void Say()
        {
            Console.WriteLine($"我是日本人，我叫{this.Name}");
        }
    }

    public abstract class Animal
    {
        public abstract void Bark();
    }

    public class Cat : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("喵~");
        }
    }

    public class Dog : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("汪~");
        }
    }
}
