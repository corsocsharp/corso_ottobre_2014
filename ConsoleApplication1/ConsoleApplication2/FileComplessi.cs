using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApplication2
{
    class FileComplessi
    {
        public static void Elabora() {

            string[] dati = File.ReadAllLines("dati-complessi.txt");

            string[] output = new string[dati.Length];

            for (int i = 0; i < dati.Length; i++) {

                string datiRiga = dati[i];

                output[i] = ElaboraRiga(datiRiga);
            
            }

            File.WriteAllLines("out.txt", output);

        }

        private static string ElaboraRiga(string datiRiga)
        {
            // 12;33;55;6;78;9
            string[] parti = datiRiga.Split(';');

            int somma = 0;
            int numValori = 0;

            for (int i = 0; i < parti.Length; i++) {
                string txt = parti[i];
                if (Utils.ControllaNumero(txt)) {
                    int val = Convert.ToInt32(txt);
                    somma += val;
                    numValori++;
                }
            }

            double media = somma / (double)numValori;

            string risultato =
                String.Format("Valori: {0}  Somma: {1}  Media: {2}",
                             numValori, somma, media);

            return risultato;
        }

        private static void EsempioSplit()
        {

            string input = "10x22x5";

            string[] parti = input.Split('x');

            Console.WriteLine("Altezza: {0}", parti[0]);
            Console.WriteLine("Larghezza: {0}", parti[1]);
            Console.WriteLine("Profondità: {0}", parti[2]);
        }

        private static void CalcolaVolumeDaStringaComplesso()
        {
            string input = "10x22x5";

            int pos1 = input.IndexOf("x");
            string part1 = input.Substring(0, pos1);

            int pos2 = input.IndexOf("x", pos1 + 1);
            string part2 = input.Substring(pos1 + 1, pos2 - pos1 - 1);

            string part3 = input.Substring(pos2 + 1);

            Console.WriteLine("Altezza: {0}", part1);
            Console.WriteLine("Larghezza: {0}", part2);
            Console.WriteLine("Profondità: {0}", part3);
        }

        private static void CalcolaAreaDaStringa()
        {
            string input = "105x22";
            int pos = input.IndexOf("x");

            string part1 = input.Substring(0, pos);
            string part2 = input.Substring(pos + 1);

            int lung = Convert.ToInt32(part1);
            int alt = Convert.ToInt32(part2);
            int area = lung * alt;

            Console.WriteLine("Altezza: {0}", part1);
            Console.WriteLine("Larghezza: {0}", part2);
            Console.WriteLine("Area: {0}", area);
        }
    }
}
