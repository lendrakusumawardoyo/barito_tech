using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoalNo1
{
    class Program
    {
        static List<string> lstPenggalanKata;
        static void Main(string[] args)
        {
            lstPenggalanKata = new List<string>();

            string initialStopInsertPenggalan = "";

            do
            {
                Console.Write("Inputkan penggalan kata, ketik tanda pagar (#) jika selesai:");
                initialStopInsertPenggalan = Console.ReadLine();

                if (initialStopInsertPenggalan != "#")
                {
                    lstPenggalanKata.Add(initialStopInsertPenggalan);
                    initialStopInsertPenggalan = "";
                }

            } while (initialStopInsertPenggalan.ToUpper() == "");

            string kata = "";

            do
            {
                Console.Write("Inputkan kata yg akan dipenggal, jika tidak inputkan tanda pagar (#):");
                kata = Console.ReadLine();

                if (kata != "#")
                {
                    for (int i = 0; i < lstPenggalanKata.Count; i++)
                    {
                        kata = kata.ToLower();
                        if (kata.StartsWith(lstPenggalanKata[i].ToLower()))
                        {
                            List<string> lstPenggalan = new List<string> { lstPenggalanKata[i].ToLower() };

                            PemenggalanKata(kata, ref lstPenggalan);

                            Console.WriteLine(String.Join(",", lstPenggalan));
                        }
                    }
                    kata = "";
                }

            } while (kata == "");

        }

        private static void PemenggalanKata(string kata, ref List<string> lstPenggalan)
        {
            string sisaKata = kata.Substring(String.Join("", lstPenggalan).Length);

            for (int i = 0; i < lstPenggalanKata.Count; i++)
            {
                sisaKata = sisaKata.ToLower();
                if (sisaKata.StartsWith(lstPenggalanKata[i].ToLower()))
                {
                    lstPenggalan.Add(lstPenggalanKata[i].ToLower());

                    PemenggalanKata(kata, ref lstPenggalan);
                }
            }
        }
    }
}
