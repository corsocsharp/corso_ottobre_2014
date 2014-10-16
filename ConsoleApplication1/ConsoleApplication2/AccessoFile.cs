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

            int padding = CalcolaPadding(dati.Length);
            string formatoOutput = "{0,"+padding+"}: {1} ({2})";

            for (int i = 0; i < dati.Length; i++)
            {
                string riga = dati[i];

                string rigaOutput = String.Format(formatoOutput,
                        i + 1, riga, riga.Length);

                output[i] = rigaOutput;
            }

            File.WriteAllLines("out.txt", output);
            Console.WriteLine("Fatto!");
            
        }

        private static int CalcolaPadding(int lunghezza)
        {
            if (lunghezza < 10) return 1;
            if (lunghezza < 100) return 2;
            if (lunghezza < 1000) return 3;
            if (lunghezza < 10000) return 4;
            return 5;
        }

        private static void ElaboraRigheLunghezzaFile()
        {
            string[] dati = File.ReadAllLines("dati.txt");

            string[] output = new string[dati.Length];

            for (int i = 0; i < dati.Length; i++)
            {
                string riga = dati[i];

                string rigaOutput = String.Format("{0,4}: {1} ({2})",
                        i + 1, riga, riga.Length);

                output[i] = rigaOutput;
            }

            File.WriteAllLines("out.txt", output);
            Console.WriteLine("Fatto!");
        }

        private static void ElaboraLunghezzaRigheFormat()
        {
            string[] dati = File.ReadAllLines("dati.txt");

            string[] output = new string[dati.Length];

            for (int i = 0; i < dati.Length; i++)
            {
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
