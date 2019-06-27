using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02默认编码的汉字字节
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "汉子对什么啊";
            //这里的默认编码就是当前电脑的默认编码，为GB2312   汉字也是2字节

            //ASCII编码中，英文和汉字所占的编码数是一样的 1字节
            //Unicode编码中，汉子和英文都是2字节
            int i = Encoding.Default.GetBytes(str).Length;
            int j = str.Length;
            Console.WriteLine("i=" + i + "  j=" + j);
            Console.WriteLine(Encoding.Default.EncodingName);
            Console.ReadKey();

            //int n = Convert.ToInt32("112300", 10);
            //Console.WriteLine(n);
            //Console.ReadKey();

            

        }
    }
}
