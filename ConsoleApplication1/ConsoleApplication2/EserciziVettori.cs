using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class EserciziVettori
    {
        public static void EseguiEsercizi() {
            PariDispari();
        }

        private static void PariDispari()
        {
            string[] valori = new string[100];

            int numValori = 0;

            while (true)
            {
                string val = Utils.LeggiTesto("Inserisci un testo");

                if (String.IsNullOrWhiteSpace(val)) break;

                valori[numValori] = val;

                numValori++;
            }


            // ciclo sugli indici pari -> posizioni dispari
            for (int i = 0; i < numValori; i += 2)
            {
                Console.Write("{0} ", valori[i]);
            }

            Console.WriteLine("");

            // ciclo sugli indici dispari -> posizioni pari
            for (int i = 1; i < numValori; i += 2)
            {
                Console.Write("{0} ", valori[i]);
            }

            Console.WriteLine("\n");
            // controllo sul valore dell'indice con il modulo
            for (int i = 0; i < numValori; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0} ", valori[i]);
                }
            }
            Console.WriteLine("");
            for (int i = 0; i < numValori; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write("{0} ", valori[i]);
                }
            }
        }

        private static void MaggioreMinore()
        {
            int[] valori = new int[50];

            int numValori = 0;

            bool continua = true;
            while (continua)
            {
                string txt = Utils.LeggiTesto("Inserisci un altro numero");

                if (Utils.ControllaNumero(txt))
                {
                    int numero = Convert.ToInt32(txt);
                    valori[numValori] = numero;
                    numValori++;
                }
                else
                {
                    continua = false;
                }
            }

            int minimo = Int32.MaxValue;
            int massimo = Int32.MinValue;

            for (int i = 0; i < numValori; i++)
            {
                int numero = valori[i];

                if (numero > massimo)
                {
                    massimo = numero;
                }

                if (numero < minimo)
                {
                    minimo = numero;
                }

            }

            if (numValori == 0)
                Console.WriteLine("Non hai inserito alcun valore");
            else
                Console.WriteLine("Max: {0}  Min: {1}", massimo, minimo);
        }
    }
}
