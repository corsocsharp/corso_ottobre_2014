using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication2
{
    class FileComplessi
    {
        public static void Elabora() {

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
