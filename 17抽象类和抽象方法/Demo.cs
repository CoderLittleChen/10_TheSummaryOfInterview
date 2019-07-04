using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17抽象类和抽象方法
{
    public static class Demo
    {
        public static int Num { get; set; }
        public static void Test()
        {
            //静态类和抽象类是相反的
            //非静态类中可以存在静态方法，但静态类中的成员必须都是静态的
            //抽象类中的成员可以是非抽象的，但是如果类中有抽象成员，该类必须是抽象类
        }
    }
}
