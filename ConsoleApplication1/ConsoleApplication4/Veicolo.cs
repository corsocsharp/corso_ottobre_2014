using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Veicolo
    {
        public string Nome = "Veicolo generico";
        public int NumeroPasseggeri = 1;

        public virtual void Vai() {
            Console.WriteLine(Nome + ": Vado");
        }
    }
}
