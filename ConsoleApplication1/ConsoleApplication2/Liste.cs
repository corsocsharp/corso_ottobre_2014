using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Liste
    {
        static public void Programma() {

            List<string> stringhe = new List<string>();

            List<double> numeri = new List<double>();

            stringhe.Add("sdfasd");
            stringhe.Add("ulla!");

            stringhe[0] = "aaaaa";

            Console.WriteLine("La lista contiene: " + stringhe.Count);

            foreach (string testo in stringhe) {
                Console.WriteLine("=> {0}", testo);
            } 


            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict["pippo"] = "23";
            dict["pluto"] = "72";
            dict.Add("qui", "33");

            

            foreach (string key in dict.Keys) {
                string val = dict[key];
                Console.WriteLine("k: {0}  => {1}", key, val);

            }


            //Console.WriteLine("" + dict["pippo"]);


            

        }
    }
}
