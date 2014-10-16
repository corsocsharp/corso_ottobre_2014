using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Cliente
    {
        public int Id;
        public string Nome;
        public string Cognome;
        public string Indirizzo;
        public int AnnoNascita;

        public string Stampa() {
            string risultato = 
                String.Format("{0}: {1} {2}", Id, Nome, Cognome);
            return risultato;
        }

        public int CalcolaEta() {
            return DateTime.Now.Year - this.AnnoNascita;
        }

        public int CalcolaDifferenzaEta(Cliente altroCliente) {
            return altroCliente.AnnoNascita - this.AnnoNascita;
        }
    }
}
