using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaTinta
{
    class Program
    {
        static void Main(string[] args)
        {
            double area;
            double valorLata = 80.0;
            double tintaLata = 18;

            Console.WriteLine("Digite o tamanho da área a ser pintada(M2): ");
            area = Convert.ToDouble(Console.ReadLine());
            double qtdTinta = area / 3;
            double qtdLatas = Math.Ceiling(qtdTinta / tintaLata);
            //Math.Ceilling arrendonda para cima           
            double valorTotal = valorLata * qtdLatas;
            Console.WriteLine("VALOR TOTAL = R$" + valorTotal);
            Console.ReadKey();
        }
    }
}
