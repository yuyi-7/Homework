using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 求和
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0, unit;
            for (unit=1;unit<=100;unit++)
            {
                sum = sum + unit;
            }
            Console.WriteLine("求和的值为{0}",sum);
            Console.ReadKey();
        }
    }
}
