using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Auto : Veicolo4Ruote, IVeicoliAMotore, ITargato
    {
        public Auto() {
            Nome = "Auto";
        }


        public void Accendi()
        {
            Console.WriteLine(Nome + " Accendo il motore");
        }

        public void Spegni()
        {
            Console.WriteLine(Nome + " Spengo");
        }
    }
}
