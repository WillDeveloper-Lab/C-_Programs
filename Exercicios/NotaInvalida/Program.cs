using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaInvalida
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean passa = false;
            while (passa == false)
            {
                Console.Write("Digite um numero entre 0 e 10: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num >= 0 && num <= 10)
                {
                    Console.WriteLine("Obrigado por nos dar uma nota!!!");
                    passa = true;
                }
                else
                {
                    Console.WriteLine("Erro, por favor digite novamente");
                }
            }
            Console.ReadKey();
        }
    }
}
