using System;
using System.Collections.Generic;

namespace Demo20_泛型
{
    class Program
    {
        static void Main(string[] args)
        {
            //泛型集合List<>
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.AddRange(new int[] { 100, 200, 300 });
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------");
            var list1 = list.FindAll(n => n > 100);
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------");
            //泛型集合Dictionary<K,V>
            Dictionary<int, string> people = new Dictionary<int, string>();
            people.Add(1, "张三");
            people.Add(2, "李四");
            people.Add(3, "王五");
            people.Add(4, "赵六");
            foreach (var p in people)
            {
                Console.WriteLine($"{p.Key}\t{p.Value}");
            }
            Console.WriteLine("-------------------------");
            Show("Hello!");
            Show(12345);
            Show(3 > 2);
        }

        /// <summary>
        /// 自定义泛型方法
        /// </summary>
        /// <param name="s"></param>
        /// <typeparam name="T"></typeparam>
        static void Show<T>(T s)
        {
            Console.WriteLine(s.ToString());
        }
    }
}
