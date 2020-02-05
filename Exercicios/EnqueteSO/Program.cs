using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnqueteSO
{
    class Program
    {
        static void Main(string[] args)
        {
            int digito = 7;
            double soma = 0;
            double[] sistemas = new double[6] {1500,3500,3000,500,150,150};
            string[] nomes = new string[6] {"Windows Server", "Unix", "Linux", "Netware", "Mac OS", "outros"};
            Console.WriteLine("*Vote em um Sistema Operacional*");
            Console.WriteLine("1 - Windows Server");
            Console.WriteLine("2 - Unix");
            Console.WriteLine("3 - Linux");
            Console.WriteLine("4 - Netware");
            Console.WriteLine("5 - Mac OS");
            Console.WriteLine("6 - Outros");
            Console.WriteLine("0 - Sair");
            while(digito != 0)
            {
                Console.Write("Escolha um sistema: ");
                digito = Convert.ToInt32(Console.ReadLine());
                switch (digito)
                {
                    case 1:
                        sistemas[0] += 1;
                        break;
                    case 2:
                        sistemas[1] += 1;
                        break;
                    case 3:
                        sistemas[2] += 1;
                        break;
                    case 4:
                        sistemas[3] += 1;
                        break;
                    case 5:
                        sistemas[4] += 1;
                        break;
                    case 6:
                        sistemas[5] += 1;
                        break;
                    case 0:
                        digito = 0;
                        break;
                }
            }

            for(int i = 0; i < 6; i++)
            {
                soma += sistemas[i];
            }
            Console.Write("Sistema Operacional     ");
            Console.WriteLine();
            Console.Write("-------------------     ");
            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                double percentual = Math.Round((sistemas[i] / soma) * 100);
                Console.WriteLine("Nome:" + nomes[i] +" Votos:" + sistemas[i] + " Percentual:" + percentual);
            }
            Console.ReadKey();
        }
    }
}
