using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4_Plarium
{/*Создать консольное приложение, удовлетворяющее следующим требованиям:
• Продемонстрировать в решении использование вложенных классов и перечисления.
• Можно сделать собственную архитектуру для решения поставленной задачи.
Создать объект класса Date, используя вложенные классы Год, Месяц, День. Методы: задать дату, вывести на консоль день недели по заданной дате. День недели представить в виде перечисления. Рассчитать количество дней, в заданном временном промежутке.
Т.е. в классе Date реализовать следующее:
public Date(int day, int month, int year)
public DayOfWeek getDayOfWeek()
public int getDayOfYear()
public int daysBetween(Date date)
В классе Year должна осуществляться проверка на високосность (можно реализовать в конструкторе) в результате, установить значение для соотв. атрибута года.
В классе Month можно сделать метод который позволит узнать количество дней для того или иного месяца [1-12]. Метод можно использовать для подсчета дней в других методах: public int getDays(int monthNumber, boolean leapYear)
Создать статический метод: public static DayOfWeek valueOf (int index)
Для того чтобы можно было после математических расчетов использовать данный метод для преобразования индекса дня недели в соотв. элемент перечисления.
Переопределите методы toString() и equals().
*/
    class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date(4, 10, 2000);
            Date date1 = new Date(6, 2, 2017);

           Console.WriteLine( date.daysBetween(date1));
            Console.WriteLine(date.getDayOfWeek());
            Console.WriteLine(date.getDayOfYear());
            Console.WriteLine(date.ToString());

        }
    }
}
