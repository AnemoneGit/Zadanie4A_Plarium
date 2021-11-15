using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4B_Plarium
{
    class PassTrain//класс поезда
    {
       private List< Vagons> Vagonss = new List< Vagons>();//список вагонов

        public PassTrain()//тут будут создаваться вагоны
        {
            Random rnd = new Random();
            int i;
            Console.WriteLine($"Введите количество вагонов");
            while (!int.TryParse(Console.ReadLine(), out i)) //цыкл ввода, если пользователь вводит не число то выдаст предупреждение
            {
                Console.WriteLine("Ошибка ввода! Введите число");
            }
            while (i != 0)
            {
                Vagons train;
                if (rnd.Next(0,2)==0)
                 train = new PassVagon(rnd.Next(1, 100), rnd.Next(1, 100));
                else  train = new VagonRestoran(rnd.Next(1, 100), rnd.Next(1, 100));
                train.Number = i;
                try 
                { 
                   Vagonss.Add(train);
                    i--;
                }
                catch
                {
                
                }
                
                
            }
        }

        public void GetOll()//метод считает количество багажа и пассажиров
        {
         
            int ollP = 0, ollB=0;

            
            foreach (Vagons s in Vagonss)
            {
                ollP += s.CountPass;
                ollB += s.CountBaggaj;
            }
            Console.WriteLine($"всего {ollP} пассажиров и {ollB} багажа");
         
        }
        public void GetVagon()//получаем интересующий нас вагон
        {
            int i,j;
            Console.WriteLine($"Введите первый параметр");
            while (!int.TryParse(Console.ReadLine(), out i)) //цыкл ввода, если пользователь вводит не число то выдаст предупреждение
            {
                Console.WriteLine("Ошибка ввода! Введите число");
            }
            
            Console.WriteLine($"Введите второй параметр");
            while (!int.TryParse(Console.ReadLine(), out j)) //цыкл ввода, если пользователь вводит не число то выдаст предупреждение
            {
                Console.WriteLine("Ошибка ввода! Введите число");
            }
            
 
            foreach (Vagons s in Vagonss)
            {
               if(s.Test(i,j))
                    Console.WriteLine($"{s.GetInfo()} с номером {s.Number} имеет заданное количество пассажиров");
            }
            
        }
        public override string ToString()//переопределенный метод ToString который реализует сортировку
        {
            var result = from vag in Vagonss
                         orderby vag.lvl
                         select vag;
            string si= "упорядоченный список вагонов по комфортности \n";
            foreach (Vagons s in result)
            {
                si += $"{s.GetInfo()} с номером {s.Number} имеет комфортность {s.GetLvlComfort()}\n";
                    
            }
            return si;
        }
    }
}
