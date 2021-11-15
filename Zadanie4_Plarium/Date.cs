using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4_Plarium
{
    class Date//класс даты
    {
        private Year _year;//вложенный класс года
        private Mounth _mounth;//вложенный класс месяца
        private Day _day;//вложенный класс дня


        public Date(int day, int month, int year)
        {
            _year = new Year(year);
            _mounth = new Mounth(month);
            _day = new Day(day);
        }
        public DayOfWeek getDayOfWeek()//получить день недели
        {
            int NumMonth = _mounth.NumMounth == 4 || _mounth.NumMounth == 7 ? 0 : _mounth.NumMounth == 1 || _mounth.NumMounth == 10 ? 1 : _mounth.NumMounth == 5  ? 2 : _mounth.NumMounth == 8 ? 3 : _mounth.NumMounth == 6 ? 5 : _mounth.NumMounth == 12 || _mounth.NumMounth == 9 ? 6 : 4;
            int NumYear = (6 + _year.NumYear % 100 + (_year.NumYear % 100) / 4) % 7;
            int day = (_day.NumDay + NumMonth + NumYear) % 7;
            return (DayOfWeek)day;
        }
        public int getDayOfYear()//сколько дней в году
        {
            return _year.leap ? 366 : 365;
        }
        public int daysBetween(Date date)//дней между датами
        {
            DateTime date1 = new DateTime(_year.NumYear, _mounth.NumMounth, _day.NumDay);
            DateTime date2 = new DateTime(date._year.NumYear, date._mounth.NumMounth, date._day.NumDay);
           if(date2>date1)
            return (int)(date2 - date1).TotalDays;
           else return (int)(date1 - date2).TotalDays;
        }
        
        /*вложенные классы*/
        public class Year//класс года
        {
            public int NumYear { get; }//год
            public bool leap;//високосность
            public Year(int year)
            {
                NumYear = year;
                if (year % 4 == 0) leap = true;
                else leap = false;
            }
        }

        public class Mounth//месяц
        {
            public int NumMounth { get; }//число 
            public Mounth(int mounth)
            {
                NumMounth = mounth;
            }
            public int getDays(int monthNumber, bool leapYear)//подсчет дней в месяце
            {
                if (leapYear && monthNumber == 2)
                    return (29);
                else return (28 + (monthNumber + monthNumber / 8) % 2 + 2 % monthNumber + 1 / monthNumber * 2);
               

            }
        }
        public static DayOfWeek valueOf(int index)//получение дня недели
                {
           
            return (DayOfWeek)index;
                }   
        
        public enum DayOfWeek//перечисление дней недели
        {
            Saturday,
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday
        }

        public class Day//день
        {
            public int NumDay { get; }//число
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
