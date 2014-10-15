using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Vettori
    {
        public static void ProvaVettori() {

            SommaMedia();


        }

        private static void SommaMedia()
        {
            int numValori = Utils.LeggiNumero("Quanti numeri vuoi inserire?");

            int[] valori = new int[numValori];

            for (int i = 0; i < valori.Length; i++)
            {
                valori[i] = Utils.LeggiNumero("Inserisci il valore " + i);
            }


            int somma = 0;
            for (int i = 0; i < numValori; i++)
            {
                somma += valori[i];
            }

            Console.WriteLine("La somma è: {0}", somma);

            double media = somma / (double)numValori;
            //media = somma / valori.Length;

            Console.WriteLine("La media è: {0}", media);
        }

        private static void RiempiVettoreConCiclo()
        {
            int[] valori = new int[10];

            for (int i = 0; i < valori.Length; i++)
            {
                valori[i] = i * 10;
            }

        }

        private static void StampaValoriInseriti()
        {
            int numValori = Utils.LeggiNumero("Quanti valori vuoi inserire?");

            string[] valoriInInput = new string[numValori];

            for (int i = 0; i < numValori; i++)
            {
                string val = Utils.LeggiTesto("Inserisci valore " + i);
                valoriInInput[i] = val;
            }

            for (int i = 0; i < valoriInInput.Length; i++)
            {
                Console.WriteLine("  [{0}] => {1}", i, valoriInInput[i]);
            }
        }

        private static void CalcolaSuVettore()
        {
            double[] valori = {
                4.6,23,-23,55
                ,45,34,32,9  
            };

            double somma = 0;

            for (int i = 0; i < valori.Length; i++)
            {
                somma = somma + valori[i];
            }

            double media = somma / valori.Length;

            Console.WriteLine("Lunghezza: {0}", valori.Length);
            Console.WriteLine("Somma: {0}", somma);
            Console.WriteLine("Media: {0}", media);
        }

        private static void GiocaVettori()
        {
            int num;
            num = 5;

            int[] numeri = new int[7];

            numeri[2] = 10;

            int val = numeri[2];

            numeri[0] = numeri[2] + 5;

            Console.WriteLine("0: {0}, 2 :{1} , length:{2} ",
                        numeri[0], numeri[2], numeri.Length);

            double[] coordinate = new double[] { 
                71,32,34,85,6,72,889,90,0
            };

            double[] coordinate2 = { 
                71,32,34,85,6,72,889,90,0
            };

            double[] coordinate3;
            
            coordinate3 = new double[]{ 
                71,32,34,85,6,72,889,90,0
            };

            double[] lotto;
            lotto = coordinate3;

            lotto[1] = 55;

            //coordinate3[1] => 55



            string[] nomi;
            nomi = new string[5];
            

        }
    }
}
