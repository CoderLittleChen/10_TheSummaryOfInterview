using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13递归
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 1  2  3  5  8  11  19
            Console.WriteLine(GetResult(30));
            Console.ReadKey();
        }


        public static int GetResult(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            return GetResult(n - 2) + GetResult(n - 1);
        }

    }
}
