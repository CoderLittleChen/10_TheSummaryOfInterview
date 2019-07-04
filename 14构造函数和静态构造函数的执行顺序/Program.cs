using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14构造函数和静态构造函数的执行顺序
{
    class Program
    {
        static void Main(string[] args)
        {
            //子类静态构造函数
            //父类静态构造函数
            //父类无参构造函数
            //子类无参构造函数

            //如果不考虑静态构造函数   子类在调用父类构造函数时，默认调用的是 父类的无参构造函数


            Student stu = new Student();
            Console.ReadKey();
        }
    }

    class Life
    {
        public string Name { get; set; }

        public Life()
        {
            Console.WriteLine("Life类的无参构造函数");
        }

        static Life()
        {
            Console.WriteLine("Life类的静态无参构造函数");
        }

    }


    class Person : Life
    {
        public int Num { get; set; }

        //public Person()
        //{
        //    Console.WriteLine("Person类的无参构造函数");
        //}


        //静态构造函数不允许有修饰符   每个类只能有一个静态构造函数
        //static Person()
        //{
        //    Console.WriteLine("Person类的静态构造函数");
        //}


        public Person(int num)
        {
            Num = num;
        }


    }

    class Student : Person
    {
        public new int Num { get; set; }

        public Student() : base(2)
        {
            Console.WriteLine("Student类的无参构造函数" + 2);
        }


        //静态构造函数不允许有修饰符   每个类只能有一个静态构造函数
        static Student()
        {
            Console.WriteLine("Student类的静态构造函数");
        }
    }


}
