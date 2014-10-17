using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Cerchio : FiguraGeometrica
    {
        public int Raggio;

        public Cerchio(int raggio) {
            Raggio = raggio;

            Perimetro = 2 * Math.PI * Raggio;
        }

        public override double CalcolaArea()
        {
            return Math.PI * this.Raggio * this.Raggio;
        }
    }
}
