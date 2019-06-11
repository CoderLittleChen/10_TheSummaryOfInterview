using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01string字符串在堆栈中的位置
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str=null和string str=""的区别，在堆栈中的地址表示

            #region Test1
            //&str1
            //        0x05d1e9d8
            //              * &str1: { 38263204}
            //&str2
            //        0x05d1e9d4
            //              * &str2: { 38263240}

            //string str1 = "张三";
            //string str2 = new string(new char[] { '张', '三' }); 
            #endregion


            #region 字符串new对象

            //            &str1
            //0x05d1ef08
            //    * &str1: { 37018036}
            //            &str2
            //0x05d1ef04
            //    * &str2: { 37018072}

            //这个地址说明没有用到字符串连接池，各自新建对象，赋值
            //string str1 = new string(new char[] { '张', '三' });
            //string str2 = new string(new char[] { '张', '三' });
            //str2 = str1;


            #endregion

            #region 一个字符串常量和new出来的字符串对象
            //string str1 = "张三";
            //string str2 = new string(new char[] { '张', '三' });
            ////这里如果不将str1的应用地址赋值给str2，则还是相当于new两个对象
            //str2 = str1;
            #endregion

            #region 两个字符串常量----常量池

            //只有这种情况才会用到常量池，两者的指针指向堆中的同一个地址
            string str1 = "张三";
            string str2 = "张三";

            #endregion

            Console.WriteLine(str1);
            Console.ReadKey();
        }
    }
}
