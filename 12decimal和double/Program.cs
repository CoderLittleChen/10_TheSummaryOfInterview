using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12decimal和double
{
    class Program
    {
        static void Main(string[] args)
        {
            //重写看一下  数据转换  decimal  double类型的区别     
            //为什么  5226.925  和526.925的结果不一样？
            //decimal d = Math.Round((decimal)526.925,2, MidpointRounding.AwayFromZero);
            //Console.WriteLine(d);
            //Console.ReadKey();  
            //decimal d = 1123.23M;
            //float f = 1.23f;

            //526.925  结果是526.92    526.825  结果是526.83   这是为什么？
            double b = Math.Round(526.945,2,MidpointRounding.AwayFromZero);
            Console.WriteLine(b);
            Console.ReadKey();


        }
    }
}
