using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Rettangolo
    {
        public int Base;
        public int Altezza;

        
        public Rettangolo(int valoreBase, int valoreAltezza) {
            Base = valoreBase;
            Altezza = valoreAltezza;
        }

        public Rettangolo(string infoRettangolo) {
            CaricaDaStringa(infoRettangolo);
        }


        private void CaricaDaStringa(string infoRettangolo) { 
            // 55x56
            string[] parti = infoRettangolo.Split('x');

            this.Base = Convert.ToInt32(parti[0]);
            this.Altezza = Convert.ToInt32(parti[1]);
        }
        
        public override string ToString() {
            return String.Format("Base: {0}, Altezza: {1}", this.Base, this.Altezza);
        }

        public int CalcolaArea()
        {
            return this.Altezza * this.Base;
        }

        public int CalcolaPerimetro() {
            return (this.Base + this.Altezza) * 2;
        }
    }
}
