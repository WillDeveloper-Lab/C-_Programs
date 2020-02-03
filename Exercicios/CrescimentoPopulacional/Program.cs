using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrescimentoPopulacional
{
    class Program
    {
        static void Main(string[] args)
        {
            double populacaoA = 80000;
            double populacaoB = 200000;
            int anos;
            int i = 1;
            for (anos = 0; anos < i; anos++)
            {
                if (populacaoB >= populacaoA)
                {
                    populacaoA += populacaoA * 0.03;
                    populacaoB += populacaoB * 0.015;
                    i++;
                }
            }
            Console.WriteLine($"A = {populacaoA} - B = {populacaoB}  : { anos}");
            // Console.WriteLine($"Foram necessarios {anos} anos para que a população A chegasse a: {populacaoA}");
            Console.ReadKey();
        }
    }
}
