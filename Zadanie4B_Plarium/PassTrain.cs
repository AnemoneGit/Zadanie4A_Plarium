using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4B_Plarium
{
    class PassTrain
    {
       private SortedList<int, Train> Vagonss = new SortedList<int, Train>();

        public PassTrain()
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
                Train train = new Train(rnd.Next(1, 100), rnd.Next(1, 100));
                train.Number = i;
                try 
                { 
                   Vagonss.Add(train.GetLvlComfort(),train);
                    i--;
                }
                catch
                {
                
                }
                
                
            }
        }

        public void GetOll()
        {
            ICollection<int> keys = Vagonss.Keys;
            int ollP = 0, ollB=0;

            
            foreach (int s in keys)
            {
                ollP += Vagonss[s].CountPass;
                ollB += Vagonss[s].CountBaggaj;
            }
            Console.WriteLine($"всего {ollP} пассажиров и {ollB} багажа");
         
        }
        public void GetVagon()
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
            ICollection<int> keys = Vagonss.Keys;
 
            foreach (int s in keys)
            {
               if(Vagonss[s].Test(i,j))
                    Console.WriteLine($"вагон с номером {Vagonss[s].Number} имеет заданное количество пассажиров");
            }
            
        }
        public override string ToString()
        {
            ICollection<int> keys = Vagonss.Keys;
            string si= "упорядоченный список вагонов по комфортности \n";
            foreach (int s in keys)
            {
                si += $"вагон с номером {Vagonss[s].Number} имеет комфортность {s}\n";
                    
            }
            return si;
        }
    }
}
