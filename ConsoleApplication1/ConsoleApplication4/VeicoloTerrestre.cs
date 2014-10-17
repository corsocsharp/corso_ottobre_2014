using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class VeicoloTerrestre : Veicolo
    {

        public VeicoloTerrestre() {
            Nome = "Veicolo Terrestre";
        }

        public override void Vai()
        {
            Console.WriteLine(Nome + ": Vado per terra");
        }

        public void Frena() {
            Console.WriteLine(Nome + ": Sto frenando");
        }
    }
}
