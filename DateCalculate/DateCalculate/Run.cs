using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateCalculate
{
    class RunProgram
    {
        /// <summary>
        /// check if the input is right
        /// </summary>
        /// <param name="i"></param>
        /// <param name="e"></param>
        /// <returns>if input is not right,return true</returns>
        public static bool Check(int[] i, int[] e)
        {
            if(i[0] == e[0])
            {
                if(i[1] == e[1])
                {
                    if (i[2] > e[2] || i[2] == e[2])
                    {
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                }
                else if(i[1] > e[2])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            else if(i[0] > e[0])
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        public static void Run()
        {

            int[] i = new int[3];
            int[] e = new int[3];
            Console.WriteLine("请输入初始日期：");
            for (int m = 0; m < 3; m++)
                if (!(int.TryParse(Console.ReadLine(), out i[m])))
                {
                    Console.WriteLine("输入错误，请重新输入");
                }

            Console.WriteLine("请输入结束日期：");
            for (int m = 0; m < 3; m++)
                if (!(int.TryParse(Console.ReadLine(), out e[m])))
                {
                    Console.WriteLine("输入错误，请重新输入");
                }

            if (Check(i, e))
            {
                Console.WriteLine("输入错误。请重新输入");
            }
            var date = new Date(i[0], i[1], i[2], e[0], e[1], e[2]);
            int days = date.Cal();
            Console.WriteLine("两日期中间相隔{0}天", days);
        }
    }
}
