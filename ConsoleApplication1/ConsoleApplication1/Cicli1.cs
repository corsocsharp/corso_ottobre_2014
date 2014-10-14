using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Cicli1
    {
        
        public static void Programma() {
           

        }

        private static void TestWhile1()
        {
            string testo = LeggiTesto("Inserisci testo");

            int num = LeggiNumero("Quante volte vuoi ripeterlo?");

            int contatore = 1;

            while (contatore <= num)
            {
                Console.Write(testo + " ");

                contatore = contatore + 1;
            }
        }

        public static int LeggiNumero(string testoDaVisualizzare) {
            Console.WriteLine(testoDaVisualizzare);

            string numero = Console.ReadLine();
            int num = Convert.ToInt32(numero);
            
            return num;
        }

        public static string LeggiTesto(string testoDaVisualizzare)
        {
            Console.WriteLine(testoDaVisualizzare);

            return Console.ReadLine();
        }
    }
}
