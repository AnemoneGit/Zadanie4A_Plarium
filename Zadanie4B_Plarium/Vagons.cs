using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4B_Plarium
{
    abstract class Vagons : Comfort//абстрактный класс  унаследованный от интерфейса комфорт
    {
        public int Number;//номер
        public int CountPass;//количество пассажиров
        public int CountBaggaj;//количество багажа
        public int lvl;//уровень комфорта
        public Vagons(int CountPass, int CountBaggaj)
        {
            this.CountPass = CountPass;
            this.CountBaggaj = CountBaggaj;
        }
        //абстрактные методы
        public abstract bool Test(int i, int j);
        public abstract int GetLvlComfort();
        public abstract string GetInfo();
    }

    class VagonRestoran : Vagons//вагон ресторан
    {
        public VagonRestoran(int CountPass, int CountBaggaj) : base(0, 0)//в вагоне ресторане 0 багажа и пассажиров
        {
            lvl = GetLvlComfort();
        }

        public override string GetInfo()//выводим что это именно вагон ресторан
        {
            return "вагон ресторан";
        }

        public override int GetLvlComfort()//уровень комфорта = 5 всегда
        {
            return 5;
        }

        public override bool Test(int i, int j)//тест 
        {
            if (CountPass >= i && CountPass <= j || CountPass <= i && CountPass >= j)
                return true;
            else return false;
        }
    }

    class PassVagon : Vagons//пассажирский вагон
    {
        public PassVagon(int CountPass, int CountBaggaj) : base(CountPass, CountBaggaj)
        {
            lvl = GetLvlComfort();
        }
        public override string GetInfo()//выводим что это именно пассажирский вагон 
        {
            return "пассажирский вагон";
        }
        public override int GetLvlComfort()//определяем уровень комфорта
        {
            return CountPass / CountBaggaj;
        }

        public override bool Test(int i, int j)//тест
        {
            if (CountPass >= i && CountPass <= j || CountPass <= i && CountPass >= j)
                return true;
            else return false;
        }
    }
}
