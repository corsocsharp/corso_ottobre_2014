using System;

namespace ConsoleApplication1
{
    class Leggi1
    {
        /// <summary>
        /// Legge cose e scrivi cose
        /// </summary>
        public static void Programma()
        {
            Console.WriteLine("inserisci il primo numero da moltiplicare");

            string num1 = Console.ReadLine();

            Console.WriteLine("inserisci il secondo numero da moltiplicare");

            string num2 = Console.ReadLine();

            double val1 = Convert.ToDouble(num1);
            double val2 = Convert.ToDouble(num2);

            double result = val1 * val2;

            Console.WriteLine("Prodotto: " + result);


            //Console.WriteLine("Int32.MaxValue: " + Int32.MaxValue);
            //Console.WriteLine("Int32.MinValue: " + Int32.MinValue);

            
            

        }

        private static void DuplicaIntero()
        {
            Console.WriteLine("Inserisci un numero da duplicare");

            string numero = Console.ReadLine();

            int valore = Convert.ToInt32(numero);

            int risultato = valore * 2;

            Console.WriteLine("Il doppio è: " + risultato);
        }



        /// <summary>
        /// Legge un testo e lo riscrive
        /// </summary>
        private static void Echo()
        {
            Console.WriteLine("Scrivi un valore");

            string valore;

            valore = Console.ReadLine();

            Console.WriteLine("Hai scritto: " + valore);
        }

    }
}
