using System;

namespace Demo17_多态应用
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            MobileStorage ms1 = new USBDisk();
            computer.Ms = ms1;
            computer.CPUWrite();
            computer.CPURead();
        }
    }

    public abstract class MobileStorage
    {
        public abstract void Read();
        public abstract void Write();
    }

    public class MobileDisk:MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘正在读取数据...");
        }

        public override void Write()
        {
            Console.WriteLine("移动硬盘正在写入数据...");
        }
    }

    public class USBDisk:MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("U盘正在读取数据...");
        }

        public override void Write()
        {
            Console.WriteLine("U盘正在写入数据...");
        }
    }

    public class Computer
    {
        public MobileStorage Ms { get; set; }
        public void CPURead()
        {
            Ms.Read();
        }

        public void CPUWrite()
        {
            Ms.Write();
        }
    }
}
