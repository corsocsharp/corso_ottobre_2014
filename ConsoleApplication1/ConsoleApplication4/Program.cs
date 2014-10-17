using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Veicolo v = new Veicolo();

            v.Vai();
            

            VeicoloTerrestre vt = new VeicoloTerrestre();
            vt.Vai();
            vt.Frena();

            Veicolo4Ruote v4 = new Veicolo4Ruote();
            v4.Vai();
            v4.Frena();

            Pedalo pedalo = new Pedalo();
            pedalo.Vai();
            pedalo.Frena();

            Auto auto = new Auto();
            auto.Vai();
            auto.Frena();

            Console.ReadKey();
        }
    }
}
