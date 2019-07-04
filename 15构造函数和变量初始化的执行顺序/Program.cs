using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15构造函数和变量初始化的执行顺序
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Num);
            Console.ReadKey();
        }
    }

    class Person
    {
        //变量初始化与构造函数的执行顺序
        //子类成员初始化  
        //父类成员初始化
        //父类构造函数
        //子类构造函数
        public Person()
        {
            Num = 2;
            Name = "张三";
        }
        public int Num = 1;
        public string Name = "李四";
    }

}
