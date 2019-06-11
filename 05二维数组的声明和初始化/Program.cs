using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05二维数组的声明和初始化
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 二维数组声明以及其存储方式

            //这样的数组本质是锯齿数组
            //int[][] nums = new int[3][] { new int[3] { 1, 2, 3 }, new int[5] { 11, 22, 33, 44, 55 }, new int[] { 1212, 333 } };
            //Console.WriteLine(nums[2][1]);

            #endregion

            //这样的是矩阵数组，每一行的元素个数都是一样的
            //注意在数组声明的时候，不能指定其大小，new对象，开辟空间的时候，指定行和列
            int[,] nums = new int[3, 2] { { 1, 2 }, { 1, 11 }, { 5, 55 } };
            int[] num = new int[] { 1, 2 };
            //获取该数组的维数num.Rank
            Console.WriteLine(num.Rank);
            Console.WriteLine(nums.Rank);
            //获取数组中总的元素个数
            Console.WriteLine(nums.Length);
            //返回该数组的行数
            Console.WriteLine(nums.GetLength(0));
            Console.WriteLine(nums.GetLength(1));
            Console.ReadKey();
        }
    }
}
