using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP02
{
    internal class HiringDate
    {
        #region PROPERTIES

        public int Day { get; set; }
        public int Month { get; set; }

        public int Year
        {
            get; set;
        }

        #endregion PROPERTIES

        #region CONSSTRUCTORS

        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        #endregion CONSSTRUCTORS

        #region METHODS

        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year:D4}";
        }

        public static bool CompareTwoHiringDates(HiringDate emp01, HiringDate emp02)
        {
            if (emp01.Year > emp02.Year)
                return true ;
            else if (emp01.Year < emp02.Year)
                return false;
            else if (emp01.Month > emp02.Month)
                return true ;
            else if (emp01.Month < emp02.Month)
                return false;
            else if (emp01.Day > emp02.Day)
                return true ;
            else if (emp01.Day < emp02.Day)
                return false;

            return false;
        }

        #endregion METHODS
    }
}