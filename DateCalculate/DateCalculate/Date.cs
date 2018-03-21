using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateCalculate
{
    class Date
    {
        List<int> datetime = new List<int>();
        public Date(int iyear, int imonth, int iday, int eyear, int emonth, int eday)
        {
            this.datetime.Add(iyear);
            this.datetime.Add(imonth);
            this.datetime.Add(iday);
            this.datetime.Add(eyear);
            this.datetime.Add(emonth);
            this.datetime.Add(eday);
        }

        /// <summary>
        /// judge if the year is the loop year
        /// </summary>
        /// <param name="lyear"></param>
        /// <returns>if it is loop year,return a bool true</returns>
        private bool IfLeapYear(int year)
        {

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// judge the month
        /// </summary>
        /// <param name="lmonth"></param>
        /// <returns>if it is the second month in the loop year,return bool true</returns>
        private bool IfLeap2Month(int year, int month)
        {
            if (IfLeapYear(year))
            {
                if (month == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// judge how many days in this month
        /// </summary>
        /// <param name="dtm">int year, int month</param>
        /// <returns>the days, int</returns>
        private int DayofTheMonth(int year, int month)
        {
            if (month == 2)
            {
                if (IfLeapYear(year))  //judge February
                {
                    if (IfLeap2Month(year, month))
                    {
                        return 29;
                    }
                }
                else
                {
                    return 28;
                }
            }
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30;
            }
            else  
            {
                return 31;
            }
        }

        /// <summary>
        /// how many integer number years between two date
        /// </summary>
        /// <param name="dt"></param>
        /// <returns>a list of the years</returns>
        private List<int> NumOfIntYear(List<int> dt)
        {
            var Years = new List<int>();
            for (int i = dt[0] + 1; i < dt[3]; i++)
                Years.Add(i);
            return Years;
        }

        /// <summary>
        /// Calculate how manys days between two date
        /// </summary>
        /// <param name="dtm"></param>
        /// <returns></returns>
        private int CalculateTheDate(List<int> dtm)
        {
            int months1, months2, months3;
            int days1 = 0, days2 = 0, days3 = 0;
            days1 = DayofTheMonth(dtm[0], dtm[1]) - dtm[2];
            for (months1 = dtm[1] + 1; months1 <= 12; months1++)  //day of the init year
            {

                days1 += DayofTheMonth(dtm[0], months1);
            }

            foreach (var i in NumOfIntYear(dtm))  //day of the infeter year
            {
                for (months2 = 1; months2 <= 12; months2++)
                {
                    days2 += DayofTheMonth(i, months2);
                }
            }
            if (dtm[3] > dtm[0])
            {
                for (months3 = 1; months3 <= dtm[4]; months3++)  //day of the end year
                {
                    if (months3 == dtm[4])
                    {
                        days3 += dtm[5];
                    }
                    else
                    {
                        days3 += DayofTheMonth(dtm[3], months3);
                    }
                }
            }
            return days1 + days2 + days3;
            
        }

        public int Cal()
        {
            int days = CalculateTheDate(this.datetime);
            return days;
        }

    }

}
