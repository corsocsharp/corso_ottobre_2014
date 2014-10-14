using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Utils
    {
        /// <summary>
        /// Permette all'utente di inserire una stringa di testo
        /// </summary>
        /// <param name="testoDaVisualizzare">testo presentato all'utente</param>
        /// <returns></returns>
        public static string LeggiTesto(string testoDaVisualizzare) {
            Console.WriteLine(testoDaVisualizzare);
            Console.Write("> ");
            string testo = Console.ReadLine();
            return testo;
        }
        /// <summary>
        /// Permette all'utente di inserire una stringa di testo
        /// </summary>
        /// <param name="testoDaVisualizzare">testo presentato all'utente</param>
        /// <returns></returns>
        public static int LeggiNumero(string testoDaVisualizzare)
        {
            string testo = LeggiTesto(testoDaVisualizzare);
            int numero = Convert.ToInt32(testo);
            return numero;
        }
    }
}
