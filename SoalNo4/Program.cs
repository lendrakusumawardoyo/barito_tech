using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoalNo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan harga saham setiap hari dibatasi dgn (,):");
            string hargaSaham = Console.ReadLine();

            string[] arrHargaSaham = hargaSaham.Split(',');

            Console.WriteLine(String.Join(",", arrHargaSaham));

            int profit = 0;
            int hargaBeliTerpilih = 0;
            int hargaJualTerpilih = 0;

            for (int i = 0; i < arrHargaSaham.Length; i++)
            {
                int hargaBeli = int.Parse(arrHargaSaham[i]);
                for (int j = i + 1; j < arrHargaSaham.Length; j++)
                {
                    int hargaJual = int.Parse(arrHargaSaham[j]);
                    if (hargaJual - hargaBeli > profit)
                    {
                        profit = hargaJual - hargaBeli;

                        hargaBeliTerpilih = hargaBeli;
                        hargaJualTerpilih = hargaJual;
                    }
                }
            }

            if (profit == 0)
            {
                Console.WriteLine("<tidak dapat membeli>");
            }
            else
            {
                Console.WriteLine("Harga Beli:" + hargaBeliTerpilih + "; Harga Jual:" + hargaJualTerpilih + "; Profit:" + profit);
            }

            Console.ReadLine();
        }
    }
}
