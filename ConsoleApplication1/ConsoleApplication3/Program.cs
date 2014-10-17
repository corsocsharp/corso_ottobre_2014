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

            Rettangolo r = new Rettangolo(10,22);
              
            Cerchio c = new Cerchio(10);

            Triangolo t = new Triangolo(2, 6, 9);

            Console.WriteLine("Perimetro r: " + r.Perimetro);
            Console.WriteLine("Perimetro c: " + c.Perimetro);

            FiguraGeometrica[] figure = { r,t,c };


            for (int i = 0; i < figure.Length; i++) { 
                FiguraGeometrica f = figure[i];
                double area = f.CalcolaArea();

                Console.Write(" => Area: {0}", area);
                Console.WriteLine(" => Perimetro: {0}", f.Perimetro);
            }

            //IConAngoliRetti figura = c;

            //figura.NumeroAngoliRetti();


            IConAngoliRetti[] elenco = new IConAngoliRetti[4];

            Rettangolo r1 = new Rettangolo(2, 3);
            Rettangolo r2 = new Rettangolo(2, 3);
            Rettangolo r3 = new Rettangolo(2, 3);

            Console.WriteLine("Numero rettangoli: " + Rettangolo.NumeroRettangoli);

            Rettangolo.AzzeraContantore();

            Console.WriteLine("Numero rettangoli: " + Rettangolo.NumeroRettangoli);

            Console.ReadKey();

        }

        private static void EsempioDatabaseCliente()
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
        }

        private static void RettangoliDaFile()
        {
            string[] righe = File.ReadAllLines("rettangoli.txt");

            RettangoloEsempio[] rettangoli = new RettangoloEsempio[righe.Length];

            for (int i = 0; i < righe.Length; i++)
            {
                string riga = righe[i];

                RettangoloEsempio r = new RettangoloEsempio(riga);

                rettangoli[i] = r;
            }

            for (int i = 0; i < rettangoli.Length; i++)
            {

                RettangoloEsempio r = rettangoli[i];

                int area = r.CalcolaArea();
                int perimetro = r.CalcolaPerimetro();

                Console.WriteLine("Area: {0}  Perimetro: {1}", area, perimetro);
            }
        }



        private static void EsempiRettangoli()
        {
            RettangoloEsempio r = new RettangoloEsempio(20, 45);

            string a = "dasdfd" + r;



            RettangoloEsempio altro = new RettangoloEsempio(33, 99);
            Console.WriteLine(altro);


            string data = "23x45";

            //Rettangolo r2 = new Rettangolo(0, 0);


            RettangoloEsempio r2 = new RettangoloEsempio(data);


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
