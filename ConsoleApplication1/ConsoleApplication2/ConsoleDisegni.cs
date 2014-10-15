using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class ConsoleDisegni
    {
        public static void Disegna() {

            int lato = Utils.LeggiNumero("Lato triangolo:");

            for (int r = 1; r <= lato; r++)
            {
                for (int c = 1; c <= lato; c++)
                {
                    bool disegna = c > (lato - r);

                    if (disegna)
                    {
                        Console.Write("*");
                    }
                    else 
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }

        }

        private static void Triangolo3()
        {
            int lato = Utils.LeggiNumero("Lato triangolo:");

            for (int r = 1; r <= lato; r++)
            {
                for (int c = 1; c <= lato; c++)
                {
                    if (c <= (lato - r + 1))
                    {
                        Console.Write("*");
                    }
                }
                Console.Write("\n");
            }
        }

        private static void Triangolo2()
        {
            int lato = Utils.LeggiNumero("Lato triangolo:");

            for (int r = 1; r <= lato; r++)
            {
                for (int c = 1; c <= lato; c++)
                {

                    if (c >= r)
                    {
                        Console.Write("*");
                    }
                }
                Console.Write("\n");
            }
        }

        private static void Triangolo1()
        {
            int lato = Utils.LeggiNumero("Lato triangolo:");

            for (int r = 1; r <= lato; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        private static void Rettangolo()
        {
            int righe = Utils.LeggiNumero("Righe");
            int colonne = Utils.LeggiNumero("Colonne");

            for (int r = 1; r <= righe; r++)
            {
                for (int c = 1; c <= colonne; c++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
