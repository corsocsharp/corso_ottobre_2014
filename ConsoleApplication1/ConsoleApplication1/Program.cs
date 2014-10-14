using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            //Leggi1.Programma();
            Cicli1.Programma();


            // aspetta la pressione di un tasto 
            // prima di uscire
            Console.ReadKey();
        }

        /* altro commento */


        #region primo esempio
        private static void PrimoMain()
        {
            double risultato;

            risultato = RadiceQuadrata(5.2);

            double prodotto = Moltiplica(3, 5);

            string nome = "Marco";
            string cognome = "De Nittis";

            SalvaCliente(nome, cognome);


            Console.WriteLine("Ciao!");

            Console.Read();

            Console.WriteLine("hai premuto un tasto");
        }

        /// <summary>
        /// Fai un prodotto
        /// </summary>
        /// <param name="val1">primo valore</param>
        /// <param name="val2">secondo valore</param>
        /// <returns>indovina...</returns>
        static double Moltiplica(double val1, double val2) {

            double prodotto = val1 * val2;

            return prodotto;
        
        }

        static double RadiceQuadrata(double num) {
            return 0;
        }


        static void SalvaCliente(string nome, string cognome) {

            Console.WriteLine("Cliente salvato");

        }
        #endregion
    }
}
