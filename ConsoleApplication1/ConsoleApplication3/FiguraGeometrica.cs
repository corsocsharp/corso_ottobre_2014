using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    abstract class FiguraGeometrica
    {
        public int X;
        public int Y;

        public double Perimetro;

        abstract public double CalcolaArea();

    }
}
