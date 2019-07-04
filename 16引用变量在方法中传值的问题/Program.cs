using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16引用变量在方法中传值的问题
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            int n = 44;
            string str = "原字符串";
            Modify(p,n,str);
            Console.WriteLine(p.Num + " " +p.Name);
            Console.WriteLine(n);
            Console.WriteLine(str);
            Console.ReadKey();
        }

        static void Modify(Person p,int n,string str)
        {
            p.Num = 3;
            p.Name = "dads";
            n = 4;
            str = "替换字符串";
        }

    }

    class Person
    {
        public Person()
        {
            Num = 2;
            Name = "张三";
        }
        public int Num = 1;
        public string Name = "李四";
    }

}
