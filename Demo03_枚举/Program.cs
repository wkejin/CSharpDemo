using System;

namespace Demo03_枚举
{
    /// <summary>
    /// 声明了一个名为QQState的枚举类型，各个值对应的int数值默认从0开始递增
    /// </summary>
    enum QQState
    {
        Online,
        Offline,
        Leave,
        Busy,
        QMe
    }
    class Program
    {
        static void Main(string[] args)
        {
            //使用枚举
            Console.WriteLine(QQState.Online);
            //枚举类型强制转换为int
            Console.WriteLine((int)QQState.Leave);
            //int强制转换为枚举类型
            Console.WriteLine((QQState)1);
        }
    }
}
