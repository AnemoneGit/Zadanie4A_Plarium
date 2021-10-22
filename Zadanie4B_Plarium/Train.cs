using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4B_Plarium
{
    class Train:Vagons,Comfort
    {
       
        private int Comforte;
        public Train(int CountPass, int CountBaggaj) : base( CountPass, CountBaggaj)
        {

            Comforte = CountPass / CountBaggaj;
        }

        public int GetLvlComfort()
        {
            return Comforte;
        }
        public bool Test(int i,int j)
        {
            if (CountPass >= i && CountPass <= j || CountPass <= i && CountPass >= j)
                return true;
            else return false;
        }
    }
}
