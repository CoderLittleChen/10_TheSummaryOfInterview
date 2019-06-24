using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12找出数组中重复次数为奇数的元素
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 1, 1, 2, 2, 3, 3, 3, 5, 5, 6, 4, 4, 6 };
        }

        public static int SearchItem(int[] nums)
        {
            //可以先快速排序   然后改进一下二分查找
            return 0;
        }

        /// <summary>
        /// 快速排序
        /// </summary>
        /// <returns></returns>
        public static int QuickSort(int[] nums, int low, int high)
        {
            int i = low, j = high, temp;
            temp = nums[i];
            while (i < j)
            {
                while (i < j && nums[j] >= temp)
                {
                    j--;
                }
                nums[i] = nums[j];
                while (i < j && nums[i] <= temp)
                {
                    i++;
                }
                nums[j] = nums[i];
            }
            nums[i] = temp;
            return i;
        }

    }
}
