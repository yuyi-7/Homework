using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P23
{
    class Person
    {
         public double Money { get; set; }
    }

    class StrangePerson:Person
    {
        public StrangePerson(double initMoney)
        {
            this.Money = initMoney;
        }
    }
    class Richer:Person
    {
 
    }
    class Program
    {
        static void Main(string[] args)
        {
            int day;
            var Jerry = new StrangePerson(0.01);
            var Tom = new Richer();
            for (day=0;day<30;day++)
            {
                Tom.Money += 100000;
                Jerry.Money += Jerry.Money * 2;
            }
            Console.WriteLine("富人一个月后可以得到{0}元\n陌生人一个月后可以得到{1}元",Tom.Money,Jerry.Money);
            Console.ReadKey();
        }
    }
}
