using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            DatabaseClienti db = new DatabaseClienti();
            db.Carica();

            Cliente cl = new Cliente();
            cl.Id = 1;
            cl.Nome = "asdfasd";
            cl.Cognome = "xzcxcvxcv";

            db.AggiungiCliente(cl);


            Cliente[] clienti = db.CercaClienti("marco");

            db.CancellaCliente(2);
            db.Salva();






            Console.ReadKey();

        }

        private static void RettangoliDaFile()
        {
            string[] righe = File.ReadAllLines("rettangoli.txt");

            Rettangolo[] rettangoli = new Rettangolo[righe.Length];

            for (int i = 0; i < righe.Length; i++)
            {
                string riga = righe[i];

                Rettangolo r = new Rettangolo(riga);

                rettangoli[i] = r;
            }

            for (int i = 0; i < rettangoli.Length; i++)
            {

                Rettangolo r = rettangoli[i];

                int area = r.CalcolaArea();
                int perimetro = r.CalcolaPerimetro();

                Console.WriteLine("Area: {0}  Perimetro: {1}", area, perimetro);
            }
        }



        private static void EsempiRettangoli()
        {
            Rettangolo r = new Rettangolo(20, 45);

            string a = "dasdfd" + r;



            Rettangolo altro = new Rettangolo(33, 99);
            Console.WriteLine(altro);


            string data = "23x45";

            //Rettangolo r2 = new Rettangolo(0, 0);


            Rettangolo r2 = new Rettangolo(data);


            Console.WriteLine("Data: " + data);
            Console.WriteLine(r2);
        }

        private static void EsempiClienti()
        {
            Cliente cliente1 = new Cliente();
            cliente1.Id = 1;
            cliente1.Nome = "Marco";
            cliente1.Cognome = "sdfasdf";
            cliente1.AnnoNascita = 1965;

            Cliente pippo = new Cliente();
            pippo.Id = 2;
            pippo.Nome = "Luigi";
            pippo.Cognome = "sfsdfs";
            pippo.AnnoNascita = 1972;

            string descrizioneCliente = cliente1.Stampa();

            Console.WriteLine(descrizioneCliente);

            int eta = cliente1.CalcolaEta();

            Console.WriteLine("età :" + eta);

            eta = pippo.CalcolaEta();

            Console.WriteLine("età :" + eta);

            int differenzaEta = cliente1.CalcolaDifferenzaEta(pippo);

            Console.WriteLine("differenza età: " + differenzaEta);
        }
    }
}
