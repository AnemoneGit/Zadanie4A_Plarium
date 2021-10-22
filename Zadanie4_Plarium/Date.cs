using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4_Plarium
{
    class Date
    {
        private Year _year;
        private Mounth _mounth;
        private Day _day;
     

        public Date(int day, int month, int year)
        {
            _year = new Year(year);
            _mounth = new Mounth(month);
            _day = new Day(day);
        }
        public DayOfWeek getDayOfWeek()
        {
            int NumMonth = _mounth.NumMounth == 4 || _mounth.NumMounth == 7 ? 0 : _mounth.NumMounth == 1 || _mounth.NumMounth == 10 ? 1 : _mounth.NumMounth == 5  ? 2 : _mounth.NumMounth == 8 ? 3 : _mounth.NumMounth == 6 ? 5 : _mounth.NumMounth == 12 || _mounth.NumMounth == 9 ? 6 : 4;
            int NumYear = (6 + _year.NumYear % 100 + (_year.NumYear % 100) / 4) % 7;
            int day = (_day.NumDay + NumMonth + NumYear) % 7;
            return (DayOfWeek)day;
        }
        public int getDayOfYear()
        {
            return _year.leap ? 366 : 365;
        }
        public int daysBetween(Date date)
        {
            DateTime date1 = new DateTime(_year.NumYear, _mounth.NumMounth, _day.NumDay);
            DateTime date2 = new DateTime(date._year.NumYear, date._mounth.NumMounth, date._day.NumDay);
           if(date2>date1)
            return (int)(date2 - date1).TotalDays;
           else return (int)(date1 - date2).TotalDays;
        }
        
        /*************************/
        public class Year
        {
            public int NumYear { get; }
            public bool leap;
            public Year(int year)
            {
                NumYear = year;
                if (year % 4 == 0) leap = true;
                else leap = false;
            }
        }

        public class Mounth
        {
            public int NumMounth { get; }
            public Mounth(int mounth)
            {
                NumMounth = mounth;
            }
            public int getDays(int monthNumber, bool leapYear)
            {
                if (leapYear && monthNumber == 2)
                    return (29);
                else return (28 + (monthNumber + monthNumber / 8) % 2 + 2 % monthNumber + 1 / monthNumber * 2);
               

            }
        }
        public static DayOfWeek valueOf(int index)
                {
           
            return (DayOfWeek)index;
                }   
        
        public enum DayOfWeek
        {
            Saturday,
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday
        }

        public class Day
        {
            public int NumDay { get; }
            public Day(int day)
            {
                NumDay = day;
            }
        }
        public override string ToString()
        {
            return $"Текущая дата:{_day.NumDay}.{_mounth.NumMounth}.{_year.NumYear}";
        }

    }
}
