using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;



namespace ConsoleApplication2
{
    class AccessoFile
    {
        public static void Programma() {

            string[] dati = File.ReadAllLines("dati.txt");

            string[] output = new string[dati.Length];

            for (int i = 0; i < dati.Length; i++) {
                string riga = dati[i];

                // converte da numero a stringa
                //output[i] = "" + riga.Length;
                //output[i] = Convert.ToString(riga.Length);
                output[i] = riga.Length.ToString("00000");
            }

            File.WriteAllLines("out.txt", output);
            Console.WriteLine("Fatto!");
        }

        private static void ElaboraLunghezzaRighe()
        {
            string[] dati = File.ReadAllLines("dati.txt");

            string output = "";

            for (int i = 0; i < dati.Length; i++)
            {
                string riga = dati[i];
                output += riga.Length;

                output += Environment.NewLine;
            }

            //Console.WriteLine(output);

            File.WriteAllText("out.txt", output);
        }
    }
}
