using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4B_Plarium
{
    abstract class Vagons 
    {
        public int Number;
        public int CountPass;
        public int CountBaggaj;
        public Vagons(int CountPass, int CountBaggaj)
        {
            this.CountPass = CountPass;
            this.CountBaggaj = CountBaggaj;
        }

    }
}
