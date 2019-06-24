using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11调整数组顺序使奇数在偶数前面
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 4, 6, 7, 9, 13, 16, 19, 21, 20, 22, 37 };
            Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + "  ");
            }
            Console.ReadKey();
        }

        public static void Sort(int[] nums)
        {
            int i = 0;
            int j = nums.Length - 1;
            int temp;
            while (i < j)
            {
                while (nums[j] % 2 == 0)
                {
                    j--;
                }
                while (nums[i] % 2 != 0)
                {
                    i++;
                }
                temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }

        }

    }
}
