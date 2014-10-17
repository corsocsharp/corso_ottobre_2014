using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Triangolo: FiguraGeometrica,IConAngoliRetti
    {
        public int LatoA;
        public int LatoB;
        public int LatoC;

        public Triangolo(int lato1, int lato2, int lato3) {
            this.LatoA = lato1;
            this.LatoB = lato2;
            this.LatoC = lato3;

            this.Perimetro = lato1 + lato2 + lato3;
        }

        public override double CalcolaArea()
        {
            // fasulla
            return LatoA * (LatoB / 2) * (LatoC / 2);
        }

        public int NumeroAngoliRetti()
        {
            return 3;
        }
    }
}
