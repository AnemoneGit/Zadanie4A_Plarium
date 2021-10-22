using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4B_Plarium
{
    class Program
    {
        static void Main(string[] args)
        {
            PassTrain passTrain = new PassTrain();
           Console.WriteLine( passTrain.ToString());
            passTrain.GetOll();
            passTrain.GetVagon();
            System.Console.ReadKey(true);
        }
    }
}
