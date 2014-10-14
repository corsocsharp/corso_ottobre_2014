using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Cicli1
    {
        public static void Programma()
        {
            int righe = Utils.LeggiNumero("Numero righe");

            int colonne = Utils.LeggiNumero("Numero colonne");

            for (int r = 1; r <= righe; r++) {
                Console.WriteLine("R:" + r);

                for (int c = 1; c <= colonne; c++) {
                    Console.Write("  C:" + c);
                    
                    int prod = r * c;
                    Console.WriteLine(" Prodotto: " + prod);
                }
            } 


        }


        private static void CicloFor1()
        {
            string testo = Utils.LeggiTesto("Inserisci un testo");

            int numero = Utils
                .LeggiNumero("Inserisci il numero di volte da ripetere");

            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine(testo);
            }
        }



        private static void CicloWhile1()
        {
            string testo = Utils.LeggiTesto("Inserisci un testo");

            int numero = Utils
                .LeggiNumero("Inserisci il numero di volte da ripetere");

            int cont = 1;
            while (cont <= numero)
            {
                Console.WriteLine(testo);

                //cont = cont + 1;
                //cont += 1;
                cont++;
            }
        }
    }
}
