using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Rettangolo : FiguraGeometrica, IConAngoliRetti
    {
        public int Base;
        public int Altezza;

        static public int NumeroRettangoli = 0;

        public Rettangolo(int valBase, int valAltezza) {
            this.Base = valBase;
            this.Altezza = valAltezza;

            this.Perimetro = (Base + Altezza) * 2;


            NumeroRettangoli++;
        }

        public override double CalcolaArea()
        {
            return Base * Altezza;
        }

        public int NumeroAngoliRetti() {
            return 4;
        }


        public static void AzzeraContantore()
        {
            NumeroRettangoli = 0;
        }
    }
}
