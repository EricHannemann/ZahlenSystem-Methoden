using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZahlenSystem_Methoden
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Summe(3, 5));
            Console.WriteLine("Binärzahl eingeben:");
            string binäreingabe = Console.ReadLine();
            Console.WriteLine("[" + binäreingabe + "]_2 = [" + binärZuDezimal(binäreingabe) + "]_10");

            Console.WriteLine("Dezimalzahl eingeben:");
            int dezimaleingabe = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("[" + dezimaleingabe + "]_10 = [" + dezimalZuBinär(dezimaleingabe) + "]_2");

        }

        static int binärZuDezimal(string binärzahl)
        {
            int dezimalzahl = 0;

            for(int i = 0; i < binärzahl.Length; i++)
            {
                int l = binärzahl.Length;

                int intBinär = Convert.ToInt32(binärzahl[i].ToString());

                dezimalzahl += intBinär * (int)Math.Pow(2, l - i - 1); //i-1 weil i als 0 anfängt
            }

            return dezimalzahl;
        }

        static string dezimalZuBinär(int dezimalzahl)
        {
            string binärzahl = "";

            int Rest;
            int Quocient = dezimalzahl;

            while(Quocient != 0)
            {
                Rest = Quocient % 2;

                Quocient /= 2; // Quocient = Quocient / 2

                binärzahl = Rest + binärzahl; //entgegengesetze Reihenfolge!! (als binärzahl += Rest;)
                                              // Konkatenation ist nicht kommutativ

            }

            return binärzahl;
        }

        static int Summe(int a, int b)
        {
            int summe = a + b;
            return summe;
        }
    }
}
